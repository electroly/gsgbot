using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GsgBot
{
    public partial class PollGameForm : Form
    {
        private Stopwatch _stopwatch;
        private readonly Dictionary<string, Vote> _votes = new();
        private readonly Game _game;

        public PollGameForm(Game game)
        {
            InitializeComponent();
            _game = game;
            Text = $"Play {game.Name}";
        }

        private void StartGuessButton_Click(object sender, EventArgs e)
        {
            _stopGuessButton.Enabled = true;
            _startGuessButton.Enabled = false;
            _stopwatch = Stopwatch.StartNew();
            _guessTimer.Start();
            _helpLabel.Text = "Wait for votes, then click [🛑 STOP] when time is up.";
            StringBuilder sb = new();
            sb.Append(_game.GuessPeriodStartMessage);
            sb.Append(" -- ");
            var number = 1;
            foreach (var choice in _game.PollChoices)
            {
                sb.Append($"Type {number} for {choice}. ");
                number++;
            }
            Bot.Say(sb.ToString());
            Bot.MessageReceived += Bot_MessageReceived;
        }

        private void StopGuessButton_Click(object sender, EventArgs e)
        {
            _stopGuessButton.Enabled = false;
            _startGuessButton.Enabled = true;
            _stopwatch.Stop();
            _guessTimer.Stop();
            _helpLabel.Text = "Done! Results are below.";
            Bot.Say(_game.GuessPeriodEndMessage);
            Bot.MessageReceived -= Bot_MessageReceived;
        }

        private void Bot_MessageReceived(object sender, TwitchMessage e)
        {
            var user = e.Username;
            var numberOfNumbers = Regex.Matches(e.Message, @"\d+").Count;
            var maxNumber = _game.PollChoices.Count;

            if (numberOfNumbers != 1)
            {
                Bot.Whisper(user, $"I'm sorry, I didn't understand your vote! Please vote a number between 1 and {maxNumber}.");
                return;
            }

            var match = Regex.Match(e.Message, @"(\d+)");
            if (!match.Success)
                return;

            var number = int.Parse(match.Groups[1].Value);
            if (number < 1 || number > maxNumber)
            {
                Bot.Whisper(user, $"I'm sorry, I didn't understand your vote! Please vote a number between 1 and {maxNumber}.");
                return;
            }

            _votes[user] = new() { Username = user, Number = number };

            Invoke(new Action(() =>
            {
                UpdateVotesList();
            }));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateVotesList()
        {
            var totals =
                _votes.Values
                .GroupBy(x => x.Number)
                .OrderByDescending(x => x.Count())
                .Select(x => $"{x.Count()} votes - {_game.PollChoices[x.Key - 1]}")
                .ToList();
            _votesList.Items.Clear();
            foreach (var x in totals)
                _votesList.Items.Add(x);
        }

        private sealed class Vote
        {
            public string Username;
            public int Number;
        }

        private void GuessTimer_Tick(object sender, EventArgs e)
        {
            if (_stopwatch != null)
                _guessTimeLabel.Text = _stopwatch.Elapsed.ToString("m\\:ss");
        }

        private void PollGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bot.MessageReceived -= Bot_MessageReceived;
        }
    }
}

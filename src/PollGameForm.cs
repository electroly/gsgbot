using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            _helpLabel.Text = "Wait for guesses, then click [🛑 STOP] when time is up.";
            Bot.Say(_game.GuessPeriodStartMessage);
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
            var number_of_numbers = Regex.Match(e.Message, @"(\d+)").Groups.Count - 1;

            var max_number = _game.PollChoices.Count;

            if (number_of_numbers != 1)
            {
                Bot.Whisper(user, $"I'm sorry, I didn't understand your vote! Please vote a number between 1 and {max_number}.");
                return;
            }

            var match = Regex.Match(e.Message, @"(\d+)");
            if (!match.Success)
                return;

            var number = int.Parse(match.Groups[1].Value);
            if (number < 1 || number > max_number)
            {
                Bot.Whisper(user, $"I'm sorry, I didn't understand your vote! Please vote a number between 1 and {max_number}.");
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
    }
}

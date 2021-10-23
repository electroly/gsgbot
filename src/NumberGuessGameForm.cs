using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GsgBot
{
    public partial class NumberGuessGameForm : Form
    {
        private Stopwatch _stopwatch;
        private readonly Dictionary<string, Guess> _guesses = new();
        private readonly Game _game;

        public NumberGuessGameForm(Game game)
        {
            InitializeComponent();
            _game = game;
            Text = $"Play {game.Name}";
            _guessesList.ColumnWidth = (int)(_guessesList.Width / 3.5);
        }

        private void GuessTimer_Tick(object sender, EventArgs e)
        {
            if (_stopwatch != null)
                _guessTimeLabel.Text = _stopwatch.Elapsed.ToString("m\\:ss");
        }

        private void StartGuessButton_Click(object sender, EventArgs e)
        {
            _stopGuessButton.Enabled = true;
            _startGuessButton.Enabled = false;
            _stopwatch = Stopwatch.StartNew();
            _guessTimer.Start();
            _winnerGroup.Enabled = false;
            _helpLabel.Text = "Wait for guesses, then click [🛑 STOP] when time is up.";
            Bot.Say(_game.GuessPeriodStartMessage);
            Bot.MessageReceived += Bot_MessageReceived;
        }

        private static TimeSpan? ParseTimeSpan(string message)
        {
            var match = Regex.Match(message, @"(\d+):(\d\d)");
            if (match.Success)
            {
                var minutes = int.Parse(match.Groups[1].Value);
                var seconds = int.Parse(match.Groups[2].Value);
                return TimeSpan.FromMinutes(minutes) + TimeSpan.FromSeconds(seconds);
            }

            match = Regex.Match(message, @"(\d+)\s*min[^\d]*(\d+)\s*sec");
            if (match.Success)
            {
                var minutes = int.Parse(match.Groups[1].Value);
                var seconds = int.Parse(match.Groups[2].Value);
                return TimeSpan.FromMinutes(minutes) + TimeSpan.FromSeconds(seconds);
            }

            match = Regex.Match(message, @"(\d+)\s*min", RegexOptions.IgnoreCase);
            if (match.Success)
                return TimeSpan.FromMinutes(int.Parse(match.Groups[1].Value));

            match = Regex.Match(message, @"(\d+)\s*sec", RegexOptions.IgnoreCase);
            if (match.Success)
                return TimeSpan.FromSeconds(int.Parse(match.Groups[1].Value));

            return null;
        }

        private void Bot_MessageReceived(object sender, TwitchMessage e)
        {
            var user = e.Username;
            var number_of_numbers = Regex.Match(e.Message, @"(\d+)").Groups.Count - 1;

            if (number_of_numbers >= 1)
            {
                if (_game.GuessType == "Time")
                {
                    var timeSpan = ParseTimeSpan(e.Message);
                    if (!timeSpan.HasValue)
                    {
                        Bot.Whisper(user, "I'm sorry, I didn't understand your guess! Please guess a time like \"1:30\", or \"90 sec\", or \"2 min\".");
                        return;
                    }

                    _guesses[user] = new() { Username = user, Time = timeSpan.Value };
                }
                else // Number
                {
                    if (number_of_numbers != 1)
                    {
                        Bot.Whisper(user, "I'm sorry, I didn't understand your guess! Please guess a number like \"30\".");
                        return;
                    }

                    var match = Regex.Match(e.Message, @"(\d+)");
                    if (!match.Success)
                        return;

                    _guesses[user] = new() { Username = user, Number = int.Parse(match.Groups[1].Value) };
                }
            }

            Invoke(new Action(() =>
            {
                UpdateGuessesList();
            }));
        }

        private void UpdateGuessesList()
        {
            _guessesList.Items.Clear();
            if (_game.GuessType == "Time")
            {
                foreach (var g in _guesses.OrderByDescending(x => x.Value.Time))
                    _guessesList.Items.Add($"{g.Value.Time:mm\\:ss} - {g.Key}");
            }
            else
            {
                foreach (var g in _guesses.OrderByDescending(x => x.Value.Number))
                    _guessesList.Items.Add($"{g.Value.Number} - {g.Key}");
            }
        }

        private void StopGuessButton_Click(object sender, EventArgs e)
        {
            _stopGuessButton.Enabled = false;
            _startGuessButton.Enabled = true;
            _stopwatch.Stop();
            _guessTimer.Stop();
            _helpLabel.Text = "Enter the winning number, then click [👑 WINNER]";
            _winnerGroup.Enabled = true;
            _winningNumberText.Select();
            Bot.Say(_game.GuessPeriodEndMessage);
            Bot.MessageReceived -= Bot_MessageReceived;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PickWinnerButton_Click(object sender, EventArgs e)
        {
            List<Guess> winningGuesses = null;
            
            if (_game.GuessType == "Time")
            {
                var winningTime = ParseTimeSpan(_winningNumberText.Text);
                if (!winningTime.HasValue)
                {
                    MessageBox.Show(this, "Invalid winning time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var winningDistance = _guesses.Values.Min(g => Math.Abs(winningTime.Value.TotalSeconds - g.Time.TotalSeconds));

                winningGuesses = (
                    from g in _guesses.Values
                    let distance = Math.Abs(winningTime.Value.TotalSeconds - g.Time.TotalSeconds)
                    where winningDistance == distance
                    select g
                    ).ToList();
            }
            else
            {
                if (!int.TryParse(_winningNumberText.Text.Trim(), out var winningNumber))
                {
                    MessageBox.Show(this, "Invalid winning number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var winningDistance = _guesses.Values.Min(g => Math.Abs(winningNumber - g.Number));

                winningGuesses = (
                    from g in _guesses.Values
                    let distance = Math.Abs(winningNumber - g.Number)
                    where winningDistance == distance
                    select g
                    ).ToList();
            }

            if (!winningGuesses.Any())
            {
                _helpLabel.Text = "There were no guesses! Click [▶ START] to ask for guesses!";
            }
            else
            {
                using WinnersForm f = new(
                    winningGuesses.Select(x =>
                        _game.GuessType == "Time"
                        ? $"{x.Username} - {x.Time:mm\\:ss}"
                        : $"{x.Username} - {x.Number}")
                    .ToList());
                f.ShowDialog(this);
            }
        }

        private sealed class Guess
        {
            public string Username;
            public int Number;
            public TimeSpan Time;
        }
    }
}

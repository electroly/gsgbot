using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GsgBot
{
    public partial class MainForm : Form
    {
        private string _filePath;

        public MainForm()
        {
            InitializeComponent();
            Bot.LogReceived += Bot_LogReceived;
            Bot.TwitchUsername = _usernameText.Text = Settings.Default.TwitchUsername;
            Bot.TwitchToken = _tokenText.Text = Settings.Default.TwitchToken;
            Bot.Streamer = _streamerText.Text = Settings.Default.Streamer;
            if (!string.IsNullOrEmpty(Settings.Default.SetupFilePath))
                OpenSetupFile(Settings.Default.SetupFilePath);
            UpdateBotStatus();
        }

        private void Bot_LogReceived(string message)
        {
            Invoke(new Action(() =>
            {
                _logList.Items.Insert(0, $"[{DateTime.Now:h:mm:ss tt}] {message}");
            }));
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            using ChooseGameTypeForm chooseGameTypeForm = new();
            if (chooseGameTypeForm.ShowDialog(this) != DialogResult.OK)
                return;
            var gameType = chooseGameTypeForm.SelectedGameType;

            Game game = new() { Type = gameType };

            switch (game.Type)
            {
                case GameType.NumberGuess:
                    game.Name = "Balloon Pop";
                    game.GuessPeriodStartMessage = "Guess how many pumps until the balloon pops! Enter your guesses now!";
                    game.GuessPeriodEndMessage = "Time's up!";
                    break;

                case GameType.Poll:
                    game.Name = "Fruit Poll";
                    game.GuessPeriodStartMessage = "Vote for your favorite fruit now!";
                    game.GuessPeriodEndMessage = "Time's up!";
                    game.PollChoices = new List<string> { "apples", "oranges", "bananas", "grapes" };
                    break;
            }

            ShowGameSetupForm(game);

            Bot.Setup.Games.Add(game);
            UpdateGamesList();
        }

        private DialogResult ShowGameSetupForm(Game game)
        {
            switch (game.Type)
            {
                case GameType.NumberGuess:
                    using (NumberGuessSetupForm f = new(game))
                        return f.ShowDialog(this);

                case GameType.Poll:
                    using (PollSetupForm f = new(game))
                        return f.ShowDialog(this);

                default:
                    return DialogResult.Cancel;
            }
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {
            Bot.TwitchUsername = _usernameText.Text;
        }

        private void TokenText_TextChanged(object sender, EventArgs e)
        {
            Bot.TwitchToken = _tokenText.Text;
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new() { UseShellExecute = true, FileName = "https://twitchapps.com/tmi/" };
            Process.Start(psi);
        }

        private void UpdateGamesList()
        {
            _gamesList.Items.Clear();
            foreach (var g in Bot.Setup.Games)
                _gamesList.Items.Add(g.Name);
            EnableDisableGameButtons();
        }

        private void EditGameButton_Click(object sender, EventArgs e)
        {
            var index = _gamesList.SelectedIndex;
            if (index < 0 || index >= Bot.Setup.Games.Count)
                return;

            var game = Bot.Setup.Games[index];
            ShowGameSetupForm(game);
            UpdateGamesList();
        }

        private void DeleteGameButton_Click(object sender, EventArgs e)
        {
            var index = _gamesList.SelectedIndex;
            if (index < 0 || index >= Bot.Setup.Games.Count)
                return;

            var game = Bot.Setup.Games[index];
            var response = MessageBox.Show(this, $"Delete the game \"{game.Name}\"?", "Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (response != DialogResult.OK)
                return;

            Bot.Setup.Games.RemoveAt(index);
            UpdateGamesList();
        }

        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            PlayGame();
        }

        private void GamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableDisableGameButtons();
        }

        private void EnableDisableGameButtons()
        {
            var enable = _gamesList.SelectedIndex >= 0 && _gamesList.SelectedIndex < Bot.Setup.Games.Count;
            _editGameButton.Enabled = enable;
            _deleteGameButton.Enabled = enable;
            _playGameButton.Enabled = enable;
        }

        private void GamesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PlayGame();
        }

        private void PlayGame()
        {
            var index = _gamesList.SelectedIndex;
            if (index < 0 || index >= Bot.Setup.Games.Count)
                return;

            var location = _gamesGroup.PointToScreen(Point.Empty);
            var game = Bot.Setup.Games[index];
            switch (game.Type)
            {
                case GameType.NumberGuess:
                    {
                        NumberGuessGameForm f = new(game)
                        {
                            Location = location
                        };
                        f.Show(this);
                        break;
                    }
            }
        }

        private async void ConnectTwitchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Bot.TwitchUsername = _usernameText.Text;
                Bot.TwitchToken = _tokenText.Text;
                Bot.Streamer = _streamerText.Text;

                _connectTwitchButton.Enabled = false;
                _botStatusLabel.Text = "Bot status: Connecting...";
                _botStatusLabel.ForeColor = Color.Blue;
                await Task.Run(() => Bot.Connect());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdateBotStatus();
            }
        }

        private async void DisconnectTwitchButton_Click(object sender, EventArgs e)
        {
            try
            {
                _disconnectTwitchButton.Enabled = false;
                _botStatusLabel.Text = "Bot status: Disconnecting...";
                _botStatusLabel.ForeColor = Color.Blue;
                await Task.Run(() => Bot.Disconnect());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdateBotStatus();
            }
        }

        private void UpdateBotStatus()
        {
            var online = Bot.Client != null;
            _connectTwitchButton.Enabled = !online;
            _disconnectTwitchButton.Enabled = online;
            _botStatusLabel.Text = "Bot status: " + (online ? "Online" : "Offline");
            _botStatusLabel.ForeColor = online ? Color.Green : Color.Red;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.TwitchUsername = _usernameText.Text;
            Settings.Default.TwitchToken = _tokenText.Text;
            Settings.Default.SetupFilePath = _filePath ?? "";
            Settings.Default.Streamer = _streamerText.Text;
            Settings.Default.Save();
        }

        private void OpenSetupFileButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog f = new()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".gsg",
                Filter = "GSG files (*.gsg)|*.gsg",
                Multiselect = false,
                SupportMultiDottedExtensions = true,
                Title = "Open GSG File"
            };
            if (f.ShowDialog(this) != DialogResult.OK)
                return;

            var filePath = f.FileName;
            OpenSetupFile(filePath);
        }

        private void OpenSetupFile(string filePath)
        {
            Bot.Setup = JsonSerializer.Deserialize<Setup>(File.ReadAllText(filePath));
            UpdateGamesList();
            _filePath = filePath;
            Text = $"GSGBot - {Path.GetFileName(filePath)}";
        }

        private void SaveSetupFileButton_Click(object sender, EventArgs e)
        {
            if (_filePath == null)
            {
                using SaveFileDialog f = new()
                {
                    CheckPathExists = true,
                    DefaultExt = ".gsg",
                    Filter = "GSG files (*.gsg)|*.gsg",
                    SupportMultiDottedExtensions = true,
                    Title = "Save GSG File"
                };
                if (f.ShowDialog(this) != DialogResult.OK)
                    return;
                _filePath = f.FileName;
            }

            SaveSetupFile();
        }

        private void SaveSetupFile()
        {
            var json = JsonSerializer.Serialize(Bot.Setup);
            File.WriteAllText(_filePath, json);
            Text = $"GSGBot - {Path.GetFileName(_filePath)}";
        }

        private void SimulateChatMessageButton_Click(object sender, EventArgs e)
        {
            using SimulateChatMessageForm f = new();
            f.ShowDialog(this);
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            using SendChatMessageForm f = new();
            f.ShowDialog(this);
        }
    }
}

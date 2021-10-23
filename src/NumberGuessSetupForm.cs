using System;
using System.Windows.Forms;

namespace GsgBot
{
    public partial class NumberGuessSetupForm : Form
    {
        private readonly Game _game;

        public NumberGuessSetupForm(Game game)
        {
            InitializeComponent();
            _game = game;
            game.Type = GameType.NumberGuess;
            _nameText.Text = game.Name;
            _startMessageText.Text = game.GuessPeriodStartMessage;
            _endMessageText.Text = game.GuessPeriodEndMessage;
            switch (game.GuessType)
            {
                case "Number":
                default:
                    _numberRadio.Checked = true;
                    break;
                case "Time":
                    _timeRadio.Checked = true;
                    break;
            }
            _nameText.Select();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_nameText.Text))
            {
                MessageBox.Show(this, "Please enter a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _game.Name = _nameText.Text;
            _game.GuessPeriodStartMessage = _startMessageText.Text;
            _game.GuessPeriodEndMessage = _endMessageText.Text;
            _game.GuessType =
                _numberRadio.Checked ? "Number" :
                _timeRadio.Checked ? "Time" :
                "";
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

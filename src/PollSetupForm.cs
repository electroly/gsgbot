using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GsgBot
{
    public partial class PollSetupForm : Form
    {
        private readonly Game _game;

        public PollSetupForm(Game game)
        {
            InitializeComponent();
            _game = game;
            game.Type = GameType.Poll;
            _nameText.Text = game.Name;
            _startMessageText.Text = game.GuessPeriodStartMessage;
            _endMessageText.Text = game.GuessPeriodEndMessage;
            if (game.PollChoices.Count > 0)
                _choice1.Text = game.PollChoices[0];
            if (game.PollChoices.Count > 1)
                _choice2.Text = game.PollChoices[1];
            if (game.PollChoices.Count > 2)
                _choice3.Text = game.PollChoices[2];
            if (game.PollChoices.Count > 3)
                _choice4.Text = game.PollChoices[3];
            if (game.PollChoices.Count > 4)
                _choice5.Text = game.PollChoices[4];
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
            _game.GuessType = "";
            _game.PollChoices.Clear();
            foreach (var x in new[] { _choice1, _choice2, _choice3, _choice4, _choice5 })
                if (!string.IsNullOrWhiteSpace(x.Text))
                    _game.PollChoices.Add(x.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

using System;
using System.Windows.Forms;

namespace GsgBot
{
    public partial class ChooseGameTypeForm : Form
    {
        public GameType SelectedGameType { get; private set; }

        public ChooseGameTypeForm()
        {
            InitializeComponent();
        }

        private void NumberGuessButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SelectedGameType = GameType.NumberGuess;
        }

        private void PollButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SelectedGameType = GameType.Poll;
        }
    }
}

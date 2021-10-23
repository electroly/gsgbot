using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GsgBot
{
    public partial class SendChatMessageForm : Form
    {
        public SendChatMessageForm()
        {
            InitializeComponent();
        }

        private async void OkButton_Click(object sender, EventArgs e)
        {
            _okButton.Enabled = false;
            try
            {
                var message = _messageText.Text;

                if (!string.IsNullOrWhiteSpace(message))
                    await Task.Run(() => Bot.Say(message));
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _okButton.Enabled = true;
            }
        }
    }
}

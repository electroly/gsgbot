using System.Collections.Generic;
using System.Windows.Forms;

namespace GsgBot
{
    public partial class WinnersForm : Form
    {
        public WinnersForm(List<string> winners)
        {
            InitializeComponent();
            foreach (var winner in winners)
                _list.Items.Add(winner);
        }
    }
}

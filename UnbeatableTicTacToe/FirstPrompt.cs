using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnbeatableTicTacToe
{
    public partial class FirstPrompt : Form
    {
        Action<string> _callback;

        public FirstPrompt(Action<string> callback)
        {
            InitializeComponent();
            _callback = callback;
        }

        private void Selected(string player)
        {
            _callback(player);
            Close();
        }

        private void PlayerFirst(object sender, EventArgs e)
        {
            Selected("p");
        }

        private void ComputerFirst(object sender, EventArgs e)
        {
            Selected("c");
        }
    }
}

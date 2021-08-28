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
    public partial class GameEnd : Form
    {
        MainGame _game;
        public GameEnd(string winMessage, MainGame game)
        {
            InitializeComponent();
            _game = game;
            lbl_state.Text = winMessage;
        }

        private void QuitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewGame(object sender, EventArgs e)
        {
            _game.NewGame();
            Close();
        }
    }
}

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
    public partial class Form1 : Form
    {
        Dictionary<string, Button> buttonMapping;
        string[,] board = new string[3,3];
        string playerChar = "X";
        string computerChar = "O";
        public Form1()
        {

            InitializeComponent();
            ResetBoard();
            buttonMapping = new Dictionary<string, Button> {
                { "a1", btn_a1 } , {"b1", btn_b1 }, {"c1", btn_c1 },
                { "a2", btn_a2 } , {"b2", btn_b2 }, {"c2", btn_c2 },
                { "a3", btn_a3 } , {"b3", btn_b3 }, {"c3", btn_c3 }
            };
        }

        void ResetBoard()
        {
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    board[x,y] = "";
                }
            }
        }

        void BtnClick(object sender, EventArgs e)
        {
            ((Button)sender).Text = playerChar;
            int[] coord = PosToCoord(ButtonToPos((Button)sender));
            board[coord[0], coord[1]] = playerChar;
        }

        int[] PosToCoord(string pos)
        {
            int[] cord = new int[2];
            cord[0] = pos[0]-97;
            cord[1] = int.Parse(pos[1].ToString())-1;
            return cord;
        }

        string ButtonToPos(Button button)
        {
            foreach (KeyValuePair<string, Button> pair in buttonMapping)
            {
                if (pair.Value == button)
                {
                    return pair.Key;
                }
            }
            return null;
        }
    }
}

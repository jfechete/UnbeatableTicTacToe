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
                    board[x,y] = string.Empty;
                }
            }
        }

        void BtnClick(object sender, EventArgs e)
        {
            SetTile(ButtonToPos((Button)sender), playerChar);

            ComputerTurn();
        }

        void ComputerTurn() //will improve later, just here so I can code game logic
        {
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    if (board[x,y] == string.Empty)
                    {
                        Console.Out.WriteLine("Found");
                        SetTile(new int[] { x, y }, computerChar);
                        return;
                    }
                }
            }
        }

        void SetTile(int[] coord, string tileChar)
        {
            board[coord[0], coord[1]] = tileChar;
            buttonMapping[CoordToPos(coord)].Text = tileChar;
        }
        void SetTile(string pos, string tileChar)
        {
            SetTile(PosToCoord(pos), tileChar);
        }

        int[] PosToCoord(string pos)
        {
            int[] coord = new int[2];
            coord[0] = pos[0] - 97;
            coord[1] = int.Parse(pos[1].ToString()) - 1;
            return coord;
        }
        string CoordToPos(int[] coord)
        {
            string pos = string.Empty;
            pos += (char)(coord[0] + 97);
            pos += (coord[1]+1).ToString();
            return pos;
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

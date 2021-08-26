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

    public partial class MainGame : Form
    {
        readonly static Color BUTTON_OPEN_COLOR = Color.FromArgb(240,240,240);
        readonly static Color BUTTON_PRESSED_COLOR = Color.FromArgb(191, 191, 191);

        Dictionary<string, Button> buttonMapping;
        string[,] board = new string[3,3];
        string playerChar = "X";
        string computerChar = "O";
        public MainGame()
        {
            InitializeComponent();
            buttonMapping = new Dictionary<string, Button> {
                { "a1", btn_a1 } , {"b1", btn_b1 }, {"c1", btn_c1 },
                { "a2", btn_a2 } , {"b2", btn_b2 }, {"c2", btn_c2 },
                { "a3", btn_a3 } , {"b3", btn_b3 }, {"c3", btn_c3 }
            };
            NewGame();
        }

        void NewGame()
        {
            ResetBoard();
            FirstPrompt firstPrompt = new FirstPrompt(FirstTurn);
            firstPrompt.Show();
        }

        void ResetBoard()
        {
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    ResetTile(new int[] { x, y });
                }
            }
        }

        void FirstTurn(string first)
        {
            if (first == "c")
            {
                computerChar = "X";
                playerChar = "O";
                ComputerTurn();
            }
            else
            {
                playerChar = "X";
                computerChar = "O";
            }
        }

        void BtnClick(object sender, EventArgs e)
        {
            string pos = ButtonToPos((Button)sender);
            if (GetTile(pos) == string.Empty)
            {
                SetTile(pos, playerChar);

                ComputerTurn();
            }
        }

        void ComputerTurn() //will improve later, just here so I can code game logic
        {
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    if (board[x,y] == string.Empty)
                    {
                        SetTile(new int[] { x, y }, computerChar);
                        return;
                    }
                }
            }
        }

        string GetTile(int[] coord)
        {
            return board[coord[0], coord[1]];
        }

        string GetTile(string pos)
        {
            return GetTile(PosToCoord(pos));
        }

        void SetTile(int[] coord, string tileChar)
        {
            board[coord[0], coord[1]] = tileChar;
            Button button = buttonMapping[CoordToPos(coord)];
            button.Text = tileChar;
            button.BackColor = BUTTON_PRESSED_COLOR;
            button.Enabled = false;
            
        }
        void SetTile(string pos, string tileChar)
        {
            SetTile(PosToCoord(pos), tileChar);
        }

        void ResetTile(int[] coord)
        {
            board[coord[0], coord[1]] = string.Empty;
            Button button = buttonMapping[CoordToPos(coord)];
            button.Text = string.Empty;
            button.BackColor = BUTTON_OPEN_COLOR;
            button.Enabled = true;
        }
        void ResetTile(string pos)
        {
            ResetTile(PosToCoord(pos));
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

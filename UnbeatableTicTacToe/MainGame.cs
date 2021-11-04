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

        const string COMPUTER_WIN_MESSAGE = "Computer wins";
        const string PLAYER_WIN_MESSAGE = "You won!";
        const string DRAW_MESSAGE = "Draw";

        Ai ai = null;
        Dictionary<string, Button> buttonMapping;
        string[,] _board = new string[3,3];
        string _playerChar = "X";
        string _computerChar = "O";
        bool _playerCanGo = false;
        string debug_string;

        public MainGame()
        {
            InitializeComponent();
            buttonMapping = new Dictionary<string, Button> {
                { "a1", btn_a1 } , {"b1", btn_b1 }, {"c1", btn_c1 },
                { "a2", btn_a2 } , {"b2", btn_b2 }, {"c2", btn_c2 },
                { "a3", btn_a3 } , {"b3", btn_b3 }, {"c3", btn_c3 }
            };
            ai = new Ai();
            NewGame();
        }

        public void NewGame()
        {
            _playerCanGo = false;
            ResetBoard();
            FirstPrompt firstPrompt = new FirstPrompt(FirstTurn);
            firstPrompt.Show();
            ai.ResetAi();
        }

        void ResetBoard()
        {
            debug_string = string.Empty;
            for (int x = 0; x < _board.GetLength(0); x++)
            {
                for (int y = 0; y < _board.GetLength(1); y++)
                {
                    ResetTile(new int[] { x, y });
                }
            }
        }

        void FirstTurn(string first)
        {
            if (first == "c")
            {
                _computerChar = "X";
                _playerChar = "O";
                ai.SetTurn(true);
                ComputerTurn();
            }
            else
            {
                _playerChar = "X";
                _computerChar = "O";
                ai.SetTurn(false);
                _playerCanGo = true;
            }
        }

        void BtnClick(object sender, EventArgs e)
        {
            if (!_playerCanGo) { return; }

            string pos = ButtonToPos((Button)sender);
            if (GetTile(pos) == string.Empty)
            {
                _playerCanGo = false;
                SetTile(pos, _playerChar);

                if (!CheckGameEnd())
                {
                    ai.PlayerTurn(pos);
                    ComputerTurn();
                }
            }
        }

        void ComputerTurn()
        {
            SetTile(ai.ComputerTurn(), _computerChar);
            _playerCanGo = true;
            CheckGameEnd();
        }

        void GameOver(string charWon)
        {
            _playerCanGo = false;
            string message;
            if (charWon == _computerChar)
            {
                message = COMPUTER_WIN_MESSAGE;
            }
            else if (charWon == _playerChar)
            {
                message = PLAYER_WIN_MESSAGE;
                Console.Out.WriteLine(debug_string);
            }
            else
            {
                message = DRAW_MESSAGE;
            }
            GameEnd gameOverForm = new GameEnd(message, this);
            gameOverForm.Show();
        }

        bool CheckGameEnd()
        {
            //checking columns
            for (int x = 0; x < _board.GetLength(0); x++)
            {
                if (_board[x,0] != string.Empty)
                {
                    bool won = true;
                    for (int y = 1; y < _board.GetLength(1); y++)
                    {
                        if (_board[x,0] != _board[x, y])
                        {
                            won = false;
                            break;
                        }
                    }
                    if (won)
                    {

                        GameOver(_board[x, 0]);
                        return true;
                    }
                }
            }
            //checking rows
            for (int y = 0; y < _board.GetLength(1); y++)
            {
                if (_board[0, y] != string.Empty)
                {
                    bool won = true;
                    for (int x = 1; x < _board.GetLength(0); x++)
                    {
                        if (_board[0, y] != _board[x, y])
                        {
                            won = false;
                            break;
                        }
                    }
                    if (won)
                    {

                        GameOver(_board[0, y]);
                        return true;
                    }
                }
            }
            //checking diagonals
            if (_board[0,0] != string.Empty)
            {
                bool won = true;
                for (int i = 1; i < _board.GetLength(0); i++)
                {
                    if (_board[0, 0] != _board[i, i])
                    {
                        won = false;
                        break;
                    }
                }
                if (won)
                {
                    GameOver(_board[0, 0]);
                    return true;
                }
            }
            if (_board[0,_board.GetLength(0)-1] != string.Empty)
            {
                bool won = true;
                for (int i = 1; i < _board.GetLength(0); i++)
                {
                    if (_board[0, _board.GetLength(0) - 1] != _board[i, _board.GetLength(0) - 1 - i])
                    {
                        won = false;
                        break;
                    }
                }
                if (won)
                {
                    GameOver(_board[0, _board.GetLength(0) - 1]);
                    return true;
                }
            }
            //checking draw
            for (int x = 0; x < _board.GetLength(0); x++)
            {
                for (int y = 0; y < _board.GetLength(1); y++)
                {
                   if (_board[x,y] == string.Empty)
                    {
                        return false;
                    }
                }
            }
            GameOver(string.Empty);
            return true;
        }

        string GetTile(int[] coord)
        {
            return _board[coord[0], coord[1]];
        }

        string GetTile(string pos)
        {
            return GetTile(PosToCoord(pos));
        }

        void SetTile(int[] coord, string tileChar)
        {
            debug_string += (debug_string == string.Empty ? "" : ",") + CoordToPos(coord) + (tileChar == _computerChar ? "c" : "p");
            _board[coord[0], coord[1]] = tileChar;
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
            _board[coord[0], coord[1]] = string.Empty;
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

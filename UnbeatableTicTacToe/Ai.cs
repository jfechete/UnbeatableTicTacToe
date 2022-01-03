using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnbeatableTicTacToe
{
    class Ai
    {
        string _ai_file;
        dynamic _current_ai;
        Random random;

        public Ai(string ai_file)
        {
            _ai_file = ai_file;
            random = new Random();
            ResetAi();
        }

        public Ai() : this("Ai.json")
        {
        }

        public void ResetAi()
        {
            _current_ai = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(_ai_file));
        }

        public void SetTurn(bool isComputer)
        {
            if (isComputer)
            {
                _current_ai = _current_ai.first;
            }
            else
            {
                _current_ai = _current_ai.second;
            }
        }

        public void PlayerTurn(string position)
        {
            if (_current_ai.responses[position] == null)
            {
                _current_ai = _current_ai.responses["else"];
            }
            else
            {
                _current_ai = _current_ai.responses[position];
            }
        }

        public string ComputerTurn()
        {
            _current_ai = _current_ai.choices[random.Next(_current_ai.choices.Count)];
            return _current_ai.choice;
        }
    }
}

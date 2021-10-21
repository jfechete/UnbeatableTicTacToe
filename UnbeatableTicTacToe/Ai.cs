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

        public Ai(string ai_file)
        {
            _ai_file = ai_file;
            ResetAi();
        }

        public Ai() : this("Ai.json")
        {
        }

        public void ResetAi()
        {
            _current_ai = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(_ai_file));
            Console.Out.WriteLine(_current_ai.first.choices.Count);
            Console.Out.WriteLine(_current_ai.first.choices[0].choice);
        }
    }
}

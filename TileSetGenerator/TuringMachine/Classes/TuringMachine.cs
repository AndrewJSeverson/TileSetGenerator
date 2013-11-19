using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileSetGenerator.TuringMachine.Classes
{
    public class TuringMachine
    {
        public string FileName { get; set; }
        public List<char> Alphabet { get; set; }
        public List<char> StartingString { get; set; }
        public int StartingPosition { get; set; }
        public State StartingState { get; set; }
        public List<State> States { get; set; }
    }
}

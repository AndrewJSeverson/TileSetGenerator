using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileSetGenerator.TuringMachine.Classes
{
    public class State
    {
        public  Dictionary<char, Transition> Transistions { get; set; }
    }
}

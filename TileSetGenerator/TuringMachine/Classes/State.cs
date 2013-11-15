using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileSetGenerator.TuringMachine.Classes
{
    public class State
    {
        public string StateName { get; set; }
        public  Dictionary<char, Transition> Transistions { get; set; }
    }
}

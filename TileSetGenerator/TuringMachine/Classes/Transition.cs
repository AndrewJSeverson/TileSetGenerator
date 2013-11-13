using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileSetGenerator.TuringMachine.Classes
{
    public class Transition
    {
        public char WriteChar { get; set; }
        public TuringMachineSettings.TransistionDirection MovementDirection { get; set; }
        public State NextState { get; set; }
    }
}

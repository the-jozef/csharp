using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Clicker_simulator_
{
    public class Player
    {
        public int Cookies { get; set; } = 10;
        public int Day { get; set; } = 0;
        public ConsoleKeyInfo PressedKey { get; set; }
    }
}

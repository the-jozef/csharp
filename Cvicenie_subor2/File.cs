using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_subor2
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Player(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Informations()
        {
            string line;
            line =Name + "," + Age;  
            return line;
        }
        
   

    }
}

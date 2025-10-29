using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_simulator
{
    internal class Hero
    {
        public string Name {  get; set; }
        public int DMG { get; set; } = 10;
        public int HP { get; set; } = 100;

        public int ENG { get; set; } = 100;
        
        public bool Heroeffect (Monster monster)
        {
            if (ENG - 20 >= 0)
            {
                ENG = ENG - 20;
                monster.HP = monster.HP - DMG;
                return true;
            }
            else
            {
                ENG = ENG + 50;
                return false;
            }
            
            
            


        
        
        
        }
      




    }
}

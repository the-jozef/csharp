using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_2
{
    internal class Monster
    {
        public string Racetype { get; set; } 
        public int DMG { get; set; }
        public int HP { get; set; }

        public Monster(string racetype, int dMG, int hP)
        {
            Racetype = racetype;
            DMG = dMG;
            HP = hP;
        }  
        public void MonsterAttack(Hero hero)
        {
            hero.HP= hero.HP - DMG;
        }
    }
}

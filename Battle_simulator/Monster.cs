using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_simulator
{
    internal class Monster
    {
        public string Racetype { get; set; }

        public int DMG { get; set; }

        public int HP { get; set; }

        public Monster(string racetype, int hP, int dMG)
        {
            Racetype = racetype;
            DMG = dMG;
            HP = hP;
        }
        public void Monstereffect(Hero ourHero)
        {
           if (ourHero.ARMOR - DMG >= 0 )
            {
                ourHero.ARMOR = ourHero.ARMOR - DMG;
            }
           else
                ourHero.HP = ourHero.HP - DMG;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_simulator
{
    internal class Monster3
    {
        public string Racetype { get; set; }

        public int DMG { get; set; }

        public int HP { get; set; }

        public Monster3(string racetype, int hP, int dMG)
        {
            Racetype = racetype;
            DMG = dMG;
            HP = hP;
        }
        public void Monstereffect(Hero ourHero)
        {
            if (ourHero.ARMOR >= 0)
            {
                ourHero.ARMOR = ourHero.ARMOR - DMG;
                if (ourHero.ARMOR < 0)
                {
                    ourHero.HP = ourHero.HP + ourHero.ARMOR;
                    ourHero.ARMOR = 0;
                }
            }
            else
            {
                ourHero.HP = ourHero.HP - DMG;
            }
            DMG = DMG + 1;
        }
    }
}

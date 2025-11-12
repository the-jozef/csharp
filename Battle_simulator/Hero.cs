using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_simulator
{
    internal class Hero
    {
        public string Name { get; set; } = "Kristof";
        public int DMG { get; set; } = 20;
        public int HP { get; set; } = 1500;
        public int ENG { get; set; } = 100;
        public int ARMOR { get; set; } = 15;

        public bool Heroattack(Monster monster)
        {
            if (ENG - 20 >= 0)
            {
                ENG = ENG - 20;
                monster.HP = monster.HP - DMG;
                return true;
            }
            return false;
        }
        public bool EnergyRegen(Monster monster)
        {
            if (ENG < 20)
            {
                ENG = ENG + 50;
                return true;
            }
            return false;
        }
        public bool RegenAll(Hero ourHero)
        {
            HP  = 150;
            ENG  = 100;
            ARMOR  = 15;
            return true;
        }
        public bool Heroattack2(Monster2 monster2)
        {
            if (ENG - 20 >= 0)
            {
                ENG = ENG - 20;
                monster2.HP = monster2.HP - DMG;
                return true;
            }
            else
            {
                ENG = ENG + 50;
                return false;
            }
        }
        public bool EnergyRegen2(Monster2 monster2)
        {
            if (ENG < 20)
            {
                ENG = ENG + 50;
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_2
{
    internal class Hero
    {
        public string Name { get; set; } = "n";
        public int HP { get; set; } = 150;
        public int DMG { get; set; } = 10;
        public int ENG { get; set; } = 100;
        public int FireDMG { get; set; } = 25;
        public int Mana { get; set; } = 100;
        //public int Gold { get; set; } 

        public bool HeroAttack(Monster monster)
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
        public bool FireAttack(Monster monster)
        {
            Random rnd = new Random();
            int chance = rnd.Next(0, 101);
            if (chance < 50)
            {
                if (Mana - 35 >= 0)
                {
                    Mana = Mana - 35;
                    monster.HP = monster.HP - FireDMG;
                    return true;
                }
                else if (Mana <= 35)
                {
                    Mana = Mana + 15;
                    return false;
                }
            }
            if (Mana <= 35)
            {
                Mana = Mana + 15;
                return false;

            }
            return false;
        }
        public bool HeroAttack2(Monster2 monster2)
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
        public bool FireAttack2(Monster2 monster2)
        {
            Random rnd = new Random();
            int chance = rnd.Next(0, 101);
            if (chance > 50)
            {
                if (Mana - 35 >= 0)
                {
                    Mana = Mana - 35;
                    monster2.HP = monster2.HP - FireDMG;
                    return true;
                }
                else if (Mana <= 35)
                {
                    Mana = Mana + 15;
                    return false;
                }
            }
            else if (Mana <= 35)
            {
                Mana = Mana + 15;
                return false;

            }
            return false;
        }
    }
}

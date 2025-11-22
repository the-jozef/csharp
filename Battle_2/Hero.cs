using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_2
{
    internal class Hero
    {
        public string Name { get; set; } = "";
        public int Points { get; set; } = 5;
        public int HP { get; set; } = 150;
        public int MaxHP { get; set; } = 150;
        public int DMG { get; set; } = 10;
        public int ENG { get; set; } = 100;
        public int MaxENG { get; set; } = 100;
        public int FireDMG { get; set; } = 25;
        public int Mana { get; set; } = 100;
        public int MaxMana { get; set; } = 100;
        
        public override string ToString()
        {
            return $"{Name} HP: {HP} ENG: {ENG} Mana: {Mana}";
        }
        public bool HeroAttack(Monster monster)
        {
            if (ENG - 20 >= 0)
            {
                ENG = ENG - 20;
                monster.HP = monster.HP - DMG;
                return true;
            }
            return false;
        }
        public bool EnergyRegen(Monster mosnter)   //max=100  -10= 90+50 =140=100
        {
            ENG = ENG + 50;
            if (ENG >= MaxENG)
            {
                ENG = MaxENG;

            }
            return true;             
        }
        public bool FireAttack(Monster monster)
        {
            Random rnd = new Random();
            int chance = rnd.Next(0, 101);

            if (chance > 50)
            {
                if (Mana - 35 >= 0)

                {
                    Mana = Mana - 35;
                    monster.HP = monster.HP - FireDMG;
                    return true;
                }
            }
            return false;
        }
        public bool ManaRegen(Monster monster)
        {
            Mana = Mana + 15;
            if (Mana == MaxMana)
            {
                Mana = MaxMana;
            }
            return true;
        }
        //block dokoncit
        public bool BlockAttack(Monster monster)
        {
            Random rnd = new Random();
            int chance = rnd.Next(0, 101);
            if (chance > 50)
            {
                ENG = ENG - 10;
                return true;
            }
            else
            {
                HP = HP - monster.DMG;
                return false;
            }
        }


        //dokoncit
        public bool HeroAttack2(Monster2 monster2)
        {
            if (ENG - 20 >= 0)
            {
                ENG = ENG - 20;
                monster2.HP = monster2.HP - DMG;
                return true;
            }
            return false;
        }
        public bool EnergyRegen2(Monster2 mosnter2)
        {
            ENG = ENG + 50;
            return true;
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

            }
            return false;
        }
        public bool ManaRegen2(Monster2 monster2)
        {
            Mana = Mana + 15;
            return true;
        }
    }
}


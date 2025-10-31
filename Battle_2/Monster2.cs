using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_2
{
    internal class Monster2
    {
        public string Racetype { get; set; }
        public int HP {  get; set; }      
        public int WindDMG { get; set; }
        public int Mana { get; set; }

        public Monster2(string racetype, int hP, int windDMG, int mana)
        {
            Racetype = racetype;
            HP = hP;        
            WindDMG = windDMG;
            Mana = mana;
        }
        public void MonsterAttack(Hero hero)
        {
            hero.HP = hero.HP - WindDMG;
        }

    }
}

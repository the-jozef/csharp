using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Pokemons
{
    public class Enemy
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int DMG { get; set; }
        public int Energy { get; set; }
        

        public Enemy(string name,int maxHealth, int dMG, int energy)
        {
            Name = name;
            MaxHealth = maxHealth;
            DMG = dMG;
            Energy = Energy;
        }
    }
}

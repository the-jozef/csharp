using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Pokemons
{
    public class Enemy
    {
        public int MaxHealth { get; set; }
        public int DMG { get; set; }
        public int Energy { get; set; }

        public Enemy(int maxHealth, int dMG, int energy)
        {
            MaxHealth = maxHealth;
            DMG = dMG;
            Energy = Energy;
        }
    }
}

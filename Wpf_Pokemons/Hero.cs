using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Pokemons
{
    public class Hero
    {
        public int Health {  get; set; }
        public int MaxHealth { get; set; } 
        public int DMG { get; set; } 
        public int Energy {  get; set; }

        public Hero(int health, int maxHealth, int dMG, int energy)
        {
            Health = health;
            MaxHealth = maxHealth;
            DMG = dMG;
            Energy = energy;
        }
    }
}

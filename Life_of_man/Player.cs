using System;
using System.Collections.Generic;
using System.Text;

namespace Life_of_man
{
    public class Player
    {
        public string Name { get; set; } = "Player";  // Default name
        public int Health { get; set; } =100;    
        public int Food { get; set; } = 100;        
        public int Thirst { get; set; } = 100;
        public int Money { get; set; } = 150;
        public int Energy { get; set; } = 100; 
 
        // Additional player properties and methods can be added here
        public Player(string name, int health, int food, int thirst, int money, int energy)
        {
            Name = name;
            Health = health;
            Food = food;
            Thirst = thirst;
            Money = money;
            Energy = energy;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Health: {Health}, Food: {Food}, Thirst: {Thirst}, Money: {Money}, Energy: {Energy}";
        }
        public void NamePlayer(string name)
        {
            Name = name;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Life_of_man
{
    public class Player
    {
        public string Name { get; set; } = "John";  // Default name
        public string Surname { get; set; } = "Wick"; //Default surname
        public int Health { get; set; } =100;    
        public int Food { get; set; } = 100;        
        public int Thirst { get; set; } = 100;
        public int Money { get; set; } = 150;
        public int Energy { get; set; } = 100; 
 
        // Additional player properties and methods can be added here
        public override string ToString()
        {
            return $"Name: {Name}, Health: {Health}, Food: {Food}, Thirst: {Thirst}, Money: {Money}, Energy: {Energy}";
        }
        



    }
}

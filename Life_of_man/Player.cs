using System;
using System.Collections.Generic;
using System.Text;

namespace Life_of_man
{
    public class Player
    {       
        public string FullName { get; set; } = "John Wick";  // Default fullname
        public int Health { get; set; } =100;    
        public int Food { get; set; } = 100;        
        public int Thirst { get; set; } = 100;
        public int Money { get; set; } = 150;
        public int Energy { get; set; } = 100; 
 
        // Additional player properties and methods can be added here
        /*public override string ToString()
        {
            return $"{FullName} Bank account: {Money}$   Health: {Health}/100  Energy: {Energy}/100    Food: {Food}/100 Thirst: {Thirst}/100";
        }*/   
    }
}

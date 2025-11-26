using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sims_5
{
    public class Player
    {
        string Name { get; set; }
        public int Hungry { get; set; } = 100;
        public int Thirst { get; set; } = 100;      
        public int Healt { get; set; } = 100;
        public int Money { get; set; } = 50;

        public void Starve()
        {
            Hungry -= 5;
            if (Hungry <= 0)
            {
                Hungry = 0;
                Healt -= 10;
            }
        }
        public void Thrist()
        {
            Thirst -= 20;
            if (Thirst <= 0)
            {
                Thirst = 0;
                Healt -= 10;
            }          
        }
        public void Job()
        {
            Money += 25;
        }
        public void Shopfood()
        {
            if (Money > 20)
            {
                Money -= 20;
                Hungry += 25;
                return;
            }
            else
                Console.WriteLine("Not enought money");
        }
        public void Shopdrink()
        {
            if (Money > 20)
            {
                Money -= 20;
                Thirst += 45;
                return;
            }
            else
            Console.WriteLine("Not enought money");
        }
    }
}

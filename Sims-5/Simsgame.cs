using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sims_5
{
    public class Simsgame
    {
        public Player Player { get; set; } = new Player();
        public void Startgame()
        {
            bool running = true;
            while (running)
            {
                Player.Starve();
                Player.Thrist();
                Console.WriteLine();
                Console.WriteLine($"1-job  2-shop a food   3-shop a drink");
                string answer = Console.ReadLine(); 
                switch(answer)
                {
                case "1":
                        {
                            Player.Job();
                            break;
                        }
                case "2":
                        {
                            Player.Shopfood();
                            break;
                        }
                case "3":
                        {
                            Player.Shopdrink(); 
                            break;
                        }
                }               
                if (Player.Healt <= 0)
                {
                    Player.Healt = 0;
                    Console.WriteLine("Player is dead");
                    running = false;
                }
                Console.WriteLine($"Hungry: {Player.Hungry} Thirsty: {Player.Thirst} Healt: {Player.Healt} Money: {Player.Money}");
                Thread.Sleep(800);
            }
        }
    }
}

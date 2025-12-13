using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Life_of_man
{
    public class Job
    {
        public static bool Working { get; set; } = false; //at work
        public static int Salary { get; set; } = 0;
        public static int Overslept { get; set; } = 0;   
        public static int ArrivedLate { get; set; } = 0;
        public static bool Fired { get; set; } = false;    //no job
        public static bool Work(Game game,Player player)
        {            
            if (Overslept == 5 || ArrivedLate == 10)
            {
                if(Overslept == 5)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("You have been fired for oversleeping too many times.");
                }
                if(ArrivedLate == 10)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("You have been fired for arriving late too many times.");
                }
                Thread.Sleep(3000);
                Fired = true;
                Console.Clear();
                return true;
            }

            Console.Clear();
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("You'r driving to a work...");
            Thread.Sleep(2000);
          
            Time.TimeDate = Time.TimeDate.AddMinutes(Player.RandomGen.Next(35,51));
            Game.ClearLine(2);
            
            if (Overslept < 5 && Fired == false)
            {
                if (Time.TimeDate.TimeOfDay <= new TimeSpan(6, 30, 0) && Time.TimeDate.TimeOfDay >= new TimeSpan(5, 30, 0))
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("You'r working...");
                    Thread.Sleep(2500);

                    Time.TimeDate = Time.TimeDate.AddHours(8);
                    Working = true;
                    CalculateSalary(player);

                    Player.Food = Player.Food - Player.RandomGen.Next(15, 25);
                    Player.Thirsty = Player.Thirsty - Player.RandomGen.Next(25, 35);
                }
                if (Time.TimeDate.TimeOfDay > new TimeSpan(6, 30, 0) && Time.TimeDate.TimeOfDay < new TimeSpan(7, 0, 0))
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("You arrived late.");
                    ArrivedLate++;
                    Thread.Sleep(2500);

                    Console.WriteLine("You'r salary will be lower.");
                    Thread.Sleep(3000);
                    
                    Console.WriteLine("You'r working...");
                    Thread.Sleep(2500);

                    CalculateSalary(player);

                    Time.TimeDate = Time.TimeDate.AddHours(8);
                    Working = true;

                    Player.Food = Player.Food - Player.RandomGen.Next(15, 25);
                    Player.Thirsty = Player.Thirsty - Player.RandomGen.Next(25, 35);
                }
                if (Time.TimeDate.TimeOfDay > new TimeSpan(7, 1, 0))
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("You overslept and can't work.");
                    Overslept++;
                    Thread.Sleep(2500);
                }
                Game.ClearLine(2);
                Console.WriteLine("You'r driving home..");
                Thread.Sleep(2000);
                Time.TimeDate = Time.TimeDate.AddMinutes(50);
                Console.Clear();
            }
            return false; 
        }
        public static void CalculateSalary(Player player)
        {
            Console.Clear();
            int baseSalary = 50; // základný plat

            int oldPenalty = 0;

            if (oldPenalty < ArrivedLate)
            {
                oldPenalty++;
                int latePenalty = Player.RandomGen.Next(1, 3) * 10;

                 Salary = baseSalary - latePenalty;

                if (Salary < 0)
                {
                    Salary = 0;
                }
                player.Money += Salary;
            }
            else if (oldPenalty == ArrivedLate)
            {                        
                player.Money += baseSalary;
            }
            Console.SetCursorPosition(0, 2);
            Console.WriteLine($"You earned {Salary}$.");
            Thread.Sleep(3000);
            Game.ClearLine(2);
            Salary = 0;
        }
    }   
}

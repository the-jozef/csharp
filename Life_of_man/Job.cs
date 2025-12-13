using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Life_of_man
{
    public class Job
    {
        public static int Working { get; set; } = 0;
        public static int Salary { get; set; } = 0;
        public static int Overslept { get; set; } = 0;
        public static int ArrivedLate { get; set; } = 0;
        public static int Fired { get; set; } = 0;
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
                Fired = 1;
                Console.Clear();
                return true;
            }

            Console.Clear();
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("You'r driving to a work...");
            Thread.Sleep(2000);
          
            Time.TimeDate = Time.TimeDate.AddMinutes(Player.RandomGen.Next(35,51));
            Game.ClearLine(2);
            
            if (Overslept < 5 && Fired == 0)
            {
                if (Time.TimeDate.Hour < 7 && Time.TimeDate.Minute < 30)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("You'r working...");
                    Thread.Sleep(2000);

                    Time.TimeDate = Time.TimeDate.AddHours(8);
                    Working = 1;
                    CalculateSalary(player);

                    Player.Food = Player.Food - Player.RandomGen.Next(15, 25);
                    Player.Thirsty = Player.Thirsty - Player.RandomGen.Next(25, 35);
                }
                if (Time.TimeDate.Hour <= 7)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("You arrived late.");
                    ArrivedLate++;
                    Thread.Sleep(2000);

                    Console.WriteLine("You'r salary will be lower.");
                    Thread.Sleep(2000);
                    Console.WriteLine("You'r working...");
                    Thread.Sleep(2000);

                    CalculateSalary(player);

                    Time.TimeDate = Time.TimeDate.AddHours(8);
                    Working = 1;

                    Player.Food = Player.Food - Player.RandomGen.Next(15, 25);
                    Player.Thirsty = Player.Thirsty - Player.RandomGen.Next(25, 35);
                }
                if (Time.TimeDate.Hour >= 7 && Time.TimeDate.Minute >= 1)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("You overslept and can't work.");
                    Overslept++;
                    Thread.Sleep(2000);
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
                int totalSalary = baseSalary ;
                player.Money += totalSalary;
            }

            Console.SetCursorPosition(0, 2);
            Console.WriteLine($"You earned {Salary}$.");
            Thread.Sleep(3000);
            Game.ClearLine(2);
            Salary = 0;
        }
    }   
}

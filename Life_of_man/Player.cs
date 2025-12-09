using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Life_of_man
{
    public class Player
    {
        public string FullName { get; set; } = "John Wick";  // Default fullname
        public int Health { get; set; } = 100;
        public int Food { get; set; } = 100;
        public int Thirst { get; set; } = 100;
        public int Money { get; set; } = 150;
        public int Energy { get; set; } = 100;
        public static Random RandomGen { get; set; } = new Random();
        public static int AlarmHour { get; set; } = -1;
        
        
        // Additional player properties and methods can be added here         
        public static bool ShowInventory1(Shop shop)
        {









            return false;
        }
        public static bool Sleeping(Time time)
        {
            if (Time.TimeDate.Hour < 20)
            {
                if (AlarmHour != -1)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("Are you sure that you want to sleep, It is too early?");
                    while (true)
                    {
                        Console.Write("Confirm sleep? (yes/no):");
                        string answer = Console.ReadLine()!;

                        if (answer.ToLower() == "yes")
                        {                            
                            int currentHour = Time.TimeDate.Hour;
                            int hoursToAlarm = (AlarmHour - currentHour + 24) % 24;

                            if (hoursToAlarm == 0)
                                hoursToAlarm = 24; // ak je rovnaká hodina, zobudí sa nasledujúci deň

                            Time.AddTime(TimeSpan.FromHours(hoursToAlarm)); // posuň herný čas

                            AlarmHour = -1;
                            Console.Clear();
                            return true;
                        }
                        else if (answer == "no")
                        {
                            Console.WriteLine("You are continuing in play");
                            Thread.Sleep(2000);
                            return false;
                        }
                        else
                        {
                            Game.ClearLine(3);
                            Console.SetCursorPosition(0, 3);
                            Console.WriteLine("Invalid code...");
                            Thread.Sleep(800);
                            Game.ClearLine(3);
                        }
                    }
                }
                else if (AlarmHour == -1) //alarm clock is not set    x<20 19
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("Are you sure that you want to sleep, It is too early?");                  
                    while (true)
                    {   
                        Console.Write("Confirm sleep? (yes/no): ");                    
                        string answer = Console.ReadLine()!;

                        if (answer.ToLower() == "yes")
                        {
                            if (Time.TimeDate.Hour < 18)    //17-20-23
                            {
                                int Sleephour = RandomGen.Next(3, 6);

                                Time.AddTime(TimeSpan.FromHours(Sleephour));
                                AlarmHour = -1;
                                Console.Clear();
                                return true;
                            }
                            else
                            { 
                                int Sleephour = RandomGen.Next(6, 9);                    //18-0-3  

                                Time.AddTime(TimeSpan.FromHours(Sleephour));
                                AlarmHour = -1;
                                Console.Clear();
                                return true;
                            }

                        }
                        else if (answer.ToLower() == "no")
                        {
                            Console.WriteLine("You are continuing in play");
                            Thread.Sleep(2000);
                            return false;
                        }
                        else
                        {
                            Game.ClearLine(3);
                            Console.SetCursorPosition(0, 3);
                            Console.WriteLine("Invalid code...");
                            Thread.Sleep(800);   
                            Game.ClearLine(3);                           
                        }
                    }
                }
            }
            else if (Time.TimeDate.Hour >= 20)
            {
                if (AlarmHour != -1) //alarm clock is set
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("Are you sure that you want to sleep?");
                    while (true)
                    {
                        Console.Write("Confirm sleep? (yes/no): ");
                        string answer = Console.ReadLine()!;

                        if (answer.ToLower() == "yes")
                        {
                            int currentHour = Time.TimeDate.Hour;
                            int hoursToAlarm = (AlarmHour - currentHour + 24) % 24;

                            if (hoursToAlarm == 0)
                                hoursToAlarm = 24; // ak je rovnaká hodina, zobudí sa nasledujúci deň

                            Time.AddTime(TimeSpan.FromHours(hoursToAlarm)); // posuň herný čas

                            AlarmHour = -1;
                            Console.Clear();
                            return true;
                        }
                        else if (answer == "no")
                        {
                            Console.WriteLine("You are continuing in play");
                            Thread.Sleep(2000);
                            return false;
                        }
                        else
                        {
                            Game.ClearLine(3);
                            Console.SetCursorPosition(0, 3);
                            Console.WriteLine("Invalid code...");
                            Thread.Sleep(800);
                            Game.ClearLine(3);
                        }
                    }
                }
                else if (AlarmHour == -1) //alarm clock is not set
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("Are you sure that you want to sleep?");
                    while (true)
                    {
                        Console.Write("Confirm sleep? (yes/no): ");
                        string answer = Console.ReadLine()!;

                        if (answer.ToLower() == "yes")
                        {
                            int Sleephour = RandomGen.Next(3, 6);

                            Time.AddTime(TimeSpan.FromHours(Sleephour)); // posuň čas
                            AlarmHour = -1;
                            Console.Clear();
                            return true;

                        }
                        else if (answer.ToLower() == "no")
                        {
                            Console.WriteLine("You are continuing in play");
                            Thread.Sleep(2000);
                            return false;
                        }
                        else
                        {
                            Game.ClearLine(3);
                            Console.SetCursorPosition(0, 3);
                            Console.WriteLine("Invalid code...");
                            Thread.Sleep(800);   
                            Game.ClearLine(3);
                        }
                    }
                }
            }
            return false;
        }
        public static bool Alarmclock(Time time)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Do you want to end setting alarm clock?"); 
            
            ConsoleKeyInfo key;
            
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("If no press enter if yes press escape.");
            key = Console.ReadKey(true);
           
            if (key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                return false;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("Enter a number to set alarm clock");
                while (true)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine("Set the hour you want to wake up (0-12):");
                    string hourAnswer = Console.ReadLine()!;

                    if (int.TryParse(hourAnswer, out int wakeUpHour) && wakeUpHour >= 0 && wakeUpHour <= 12)
                    {
                        AlarmHour = wakeUpHour;
                        Game.ClearLine(3);
                        Console.WriteLine($"Alarm clock setted for {AlarmHour}:00.");
                        Thread.Sleep(3000);
                        Console.Clear();    
                        return true;
                    }
                    else
                    {
                        Game.ClearLine(3);
                        Game.ClearLine(4);
                        Console.SetCursorPosition(0, 3);
                        Console.WriteLine("Invalid code...");
                        Thread.Sleep(900);
                        Game.ClearLine(3);
                    }
                }
            }
            return false;
        }
    }
}

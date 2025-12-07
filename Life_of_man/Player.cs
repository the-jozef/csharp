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
            if (Time.TimeDate.Hour < 21)
            {
                if (AlarmHour != -1)
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
                            Console.WriteLine($"You are going to sleep......");

                            int currentHour = Time.TimeDate.Hour;
                            int hoursToAlarm = (AlarmHour - currentHour + 24) % 24;

                            if (hoursToAlarm == 0)
                                hoursToAlarm = 24; // ak je rovnaká hodina, zobudí sa nasledujúci deň

                            Time.TimeDate = Time.TimeDate.AddHours(hoursToAlarm); // posuň herný čas

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
                            Console.WriteLine("Invalid code...");
                            Thread.Sleep(2000);
                            break;
                        }
                    }
                }
                else if (AlarmHour == -1)
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
                            AlarmHour = RandomGen.Next(8, 12);

                            Console.WriteLine($"You are going to sleep......");

                            int currentHour = Time.TimeDate.Hour;
                            int hoursToAlarm = (AlarmHour - currentHour + 24) % 24;

                            if (hoursToAlarm == 0)
                                hoursToAlarm = 24;

                            Time.TimeDate = Time.TimeDate.AddHours(hoursToAlarm); // posuň čas
                            AlarmHour = -1;
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
                            Console.WriteLine("Invalid code...");
                            Thread.Sleep(2000);
                            break;
                        }
                    }
                }
            }
            else if (Time.TimeDate.Hour >= 21)
            {
                if (AlarmHour != -1)
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
                            Console.WriteLine($"You are going to sleep......");

                            int currentHour = Time.TimeDate.Hour;
                            int hoursToAlarm = (AlarmHour - currentHour + 24) % 24;

                            if (hoursToAlarm == 0)
                                hoursToAlarm = 24; // ak je rovnaká hodina, zobudí sa nasledujúci deň

                            Time.TimeDate = Time.TimeDate.AddHours(hoursToAlarm); // posuň herný čas

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
                            Console.WriteLine("Invalid code...");
                            Thread.Sleep(2000);
                            break;
                        }
                    }
                }
                else if (AlarmHour == -1)
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
                            AlarmHour = RandomGen.Next(8, 12);

                            Console.WriteLine($"You are going to sleep......");

                            int currentHour = Time.TimeDate.Hour;
                            int hoursToAlarm = (AlarmHour - currentHour + 24) % 24;

                            if (hoursToAlarm == 0)
                                hoursToAlarm = 24;

                            Time.TimeDate = Time.TimeDate.AddHours(hoursToAlarm); // posuň čas
                            AlarmHour = -1;
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
                            Console.WriteLine("Invalid code...");
                            Thread.Sleep(2000);
                            break;
                        }
                    }
                }
            }
            return false;
        }
        public static bool Alarmclock(Time time)
        {
            ConsoleKeyInfo key;
            Console.Clear();
            Console.SetCursorPosition(0, 2);            
            Console.WriteLine("Set the hour you want to wake up (0-23): ");
            while (true)
            {
                key = Console.ReadKey(true);
                string hourAnswer = Console.ReadLine()!;
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    return false;
                }
                if (int.TryParse(hourAnswer, out int wakeUpHour) && wakeUpHour >= 0 && wakeUpHour <= 23)
                {
                    AlarmHour = wakeUpHour;
                    Console.Clear();
                    Console.WriteLine($"Alarm set for {AlarmHour}:00.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 0 and 23.");
                    return false;
                }
            }
            
        }





    }
}

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Life_of_man
{
    public class Player : Shop
    {
        public string FullName { get; set; } = "John Wick";  // Default fullname
        public static int Health { get; set; } = 100;
        public static int Food { get; set; } = 100;
        public static int Thirsty { get; set; } = 100;
        public  int Money { get; set; } = 150;
        public int Energy { get; set; } = 100;
        public static Random RandomGen { get; set; } = new Random();
        public static int AlarmHour { get; set; } = -1;
        public static List<Player> Inventory { get; set; } = new List<Player>();
        
        
        // Additional player properties and methods can be added here         
        public static bool ShowInventory(Shop shop)
        {
            Console.Clear();                      
            Inventory.Add(new Player{ ItemName = "Orange", Quantity = 4, Price = 7, Hungry= 5,Thirst = -10});
            Inventory.Add(new Player{ ItemName = "Water Bottle", Quantity = 2, Price = 5,Hungry = 0, Thirst = 40 });
            Inventory.Add(new Player{ ItemName = "Sandwich", Quantity = 1, Price = 10,Hungry = 15, Thirst = -5 });
            Inventory.Add(new Player{ ItemName = "Apple", Quantity = 3, Price = 6,Hungry = 7, Thirst = 5 });
            int leftX = 0;
            int startY = 2;           
            int startIndexItems = 0;
            int pageSize = 20;
            int selectedIndexItems = 0;

            ConsoleKeyInfo key;

            bool running = true;
            while (running)
            {
                Console.SetCursorPosition(leftX, startY);
                Console.WriteLine("Inventory:");
                Console.WriteLine();

                for (int y = startY + 2; y < startY + pageSize + 5; y++)
                {
                    Console.SetCursorPosition(leftX + 11, y);
                    Console.Write(new string(' ', Console.WindowWidth - (leftX + 11)));
                }
                if (Inventory.Count == 0)
                {
                    Console.SetCursorPosition(leftX, startY);
                    Console.WriteLine("Inventory is empty.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    return false;
                }
                for (int i = 0; i < pageSize && startIndexItems + i < Inventory.Count; i++)
                {
                    int yPos = startY + i + 2;
                    Console.SetCursorPosition(leftX + 11, yPos);

                    Console.Write(new string(' ', Console.WindowWidth - (leftX + 11)));
                    Console.SetCursorPosition(leftX + 11, yPos);

                    if (startIndexItems + i == selectedIndexItems)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    Console.Write($"{Inventory[startIndexItems + i].Quantity}x {Inventory[startIndexItems + i].ItemName} H:{Inventory[startIndexItems + i].Hungry} T:{Inventory[startIndexItems + i].Thirst}");

                    Console.ResetColor();
                }
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.UpArrow && selectedIndexItems > 0)
                {
                    selectedIndexItems--;
                    if (selectedIndexItems < startIndexItems)
                    {
                        startIndexItems--;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow && selectedIndexItems < Inventory.Count - 1)
                {
                    selectedIndexItems++;
                    if (selectedIndexItems >= startIndexItems + pageSize)
                    {
                        startIndexItems++;
                    }
                }
                else if (key.Key == ConsoleKey.Enter)
                {          
                    var selected = Inventory[selectedIndexItems];
                    if(Player.Food <= 100)
                    {     
                        Player.Food += selected.Hungry;
                        if (Player.Food + selected.Hungry > 100)
                        {
                            Player.Food = 100;
                        }
                    }
                    if (Player.Thirsty <= 100)
                    {
                        Player.Thirsty += selected.Thirst;
                        if (Player.Thirsty + selected.Thirst > 100)
                        {
                            Player.Thirsty = 100;
                        }
                    }                    
                    if (Inventory.Count > 0)
                    {
                        var item = Inventory[selectedIndexItems];
                       
                        if (item.Quantity > 1)
                            item.Quantity--;
                        else Inventory.RemoveAt(selectedIndexItems);

                        if (selectedIndexItems >= Inventory.Count) 
                        { 
                            selectedIndexItems = Inventory.Count - 1; 
                        }
                        if (selectedIndexItems < 0)
                        {
                            selectedIndexItems = 0;
                        }
                        if (startIndexItems > selectedIndexItems)
                        { 
                            startIndexItems = selectedIndexItems; 
                        }
                    }
                }                                                                
                else if(key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.SetCursorPosition(leftX, startY);
                    Console.WriteLine("Leaving inventory...");
                    Thread.Sleep(2000);                    
                    running = false;
                }
            }
            Console.Clear();
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
            Console.WriteLine("Do you want to end setting alarm clock? (enter/escape):"); 
            Thread.Sleep(1000);
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    Game.ClearLine(2);
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("Alarm clock wasn't setted..");
                    Thread.Sleep(2000);
                    Console.Clear();
                    return false;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    while (true)
                    {
                        if (Time.TimeDate.Hour < 12 && Time.TimeDate.Hour >= 0)
                        {
                            Game.ClearLine(2);
                            Console.SetCursorPosition(0, 2);
                            Console.WriteLine("Set hour between 0-24");
                            
                            Console.SetCursorPosition(0, 3);
                            Console.WriteLine("Set up your alarm clock:");
                            string hourAnswer = Console.ReadLine()!;

                            if (int.TryParse(hourAnswer, out int WakeUpHour) && WakeUpHour < 0 || WakeUpHour > 24)
                            {
                                Console.Clear();
                                Console.SetCursorPosition(0, 2);
                                Console.WriteLine("Invalid hour, try again.");
                                Thread.Sleep(1100);
                                Game.ClearLine(2);
                            }
                            if (int.TryParse(hourAnswer, out int wakeUpHour) && wakeUpHour >= 0 && wakeUpHour <= 24)
                            {
                                AlarmHour = wakeUpHour;
                                Console.Clear();
                                Console.SetCursorPosition(0, 2);
                                Console.WriteLine($"Alarm clock setted for {AlarmHour}:00.");
                                Thread.Sleep(2500);
                                Console.Clear();
                                return true;
                            }
                        }                         
                    }
                }
            }
        }
    }
}

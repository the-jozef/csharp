using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Life_of_man
{
    public class Time
    {
        public static DateTime TimeDate { get; set; } = new DateTime(2025, 1, 29, 5, 0, 0);
        public static int DayCount { get; set; } = 1;
        public static void DrawTimeTopRight(DateTime TimeDate)
        {
            int x = Console.WindowWidth - 15;
            Console.SetCursorPosition(x, 0);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Time: {TimeDate:HH:mm:ss} ");
            
            string day = TimeDate.ToString("dddd", new CultureInfo("en")); // den v týždni v angličtine
            string formattedDay = char.ToUpper(day[0]) + day.Substring(1).ToLower();
            
            Console.SetCursorPosition(x , 1);
            Console.WriteLine($"Day:{DayCount} {formattedDay}");
            Console.ResetColor();
        }

        public static void AddTime(TimeSpan span)
        {
            DateTime oldTime = TimeDate;
            TimeDate = TimeDate.Add(span);

          
            if (TimeDate.Day != oldTime.Day || TimeDate.Month != oldTime.Month || TimeDate.Year != oldTime.Year)
            {
                DayCount++;                       
                Player.AlarmHour = -1;            
            }
        }
        public static class UIManager
        {
            public static void StartUI(Player player, DateTime TimeDate, Game game)
            {
                Console.CursorVisible = false;

                System.Timers.Timer timer = new System.Timers.Timer(1000);
                timer.Elapsed += (s, e) =>
                {
                    int OldDay = Time.TimeDate.Day;

                    Time.AddTime(TimeSpan.FromSeconds(10));
                    if (Time.TimeDate.Day != OldDay)
                    {
                        Time.DayCount++;
                        Player.AlarmHour = -1; // reset budíka 
                    }
                    lock (Console.Out)
                    {
                        Colour.PlayerStats(player);

                        Time.DrawTimeTopRight(Time.TimeDate);

                        Console.SetCursorPosition(0, 2);
                        /*
                        if (Menu.Counting == 0) //oke
                        {
                            if (Menu.Counting == 100)
                            {
                                Console.SetCursorPosition(0, 2);
                            }
                            else if (Menu.Counting == 0)
                            {
                                Console.SetCursorPosition("Menu: ".Length, 11);
                            }
                        }
                        else if (Menu.Counting == 1)
                        {
                            
                        }
                        else if (Menu.Counting == 2) //oke?
                        {
                            Console.SetCursorPosition("Confirm sleep? (yes/no):".Length + 2, 3);
                        }
                        else if (Menu.Counting == 3) //oke
                        {
                            Console.SetCursorPosition("Welcome to the shop! Use arrows to navigate, Enter to add ; Backspace to remove and Esc to end.".Length, 2);
                        }
                        else if (Menu.Counting == 4)
                        { }
                        else if (Menu.Counting == 5)
                        { }
                        else if (Menu.Counting == 6)
                        {
                            Console.SetCursorPosition("Loading".Length, 2);
                        }
                        else if (Menu.Counting == 7) //oke?
                        {
                            Console.SetCursorPosition("Set up the hour you want to wake up (0-12):".Length + 1, 3);
                        }
                        else if (Menu.Counting == 8) //oke
                        {
                            Console.SetCursorPosition("Are you sure you want to end a game? (yes/no):".Length + 2, 11);
                        }*/
                        
                    }
                };
                timer.AutoReset = true;                
                timer.Start();            
            }     
        }
        public static bool skipTime()
        {
            Console.CursorVisible = false;
            string[] menu =
            {
            "1 hour",
            "2 hours",
            "5 hours",
            "8 hours",
            "10 hours"
            };

            int[] hours = { 1, 2, 5, 8, 10 };
            
            int selectedIndex = 0;
            ConsoleKey key;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("Skip time:");
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.SetCursorPosition(11, 3 + i);

                    if (0 + i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.WriteLine(menu[i]);
                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.DownArrow && selectedIndex < menu.Length - 1)
                { selectedIndex++; }

                if (key == ConsoleKey.UpArrow && selectedIndex > 0)
                { selectedIndex--; }

            }
            while (key != ConsoleKey.Enter);

            int skipHours = hours[selectedIndex];

            Console.Clear();
            Console.SetCursorPosition(0, 2);
            Console.Write("Loading");

            int cycles = 9; // napríklad 6 krokov
            for (int i = 0; i < cycles; i++)
            {
                int dots = (i % 3) + 1; // 1,2,3,1,2,3...

                // kurzor hneď za "Loading"
                Console.SetCursorPosition("Loading".Length, Console.CursorTop);

                // napíš bodky
                Console.Write(new string('.', dots));

                // vymaž zvyšok po 3 bodkách
                Console.Write(new string(' ', 3 - dots));

                Thread.Sleep(750);  // čakaj pol sekundy

                // po 3 bodkách ich vymaž pred ďalším cyklom
                if (dots == 3)
                {
                    Console.SetCursorPosition("Loading".Length, Console.CursorTop);
                    Console.Write("   "); // vymaž všetky 3 bodky
                }
            }
            Time.TimeDate = Time.TimeDate.AddHours(skipHours);

            Console.Clear();
            return true;
        }
    }
}


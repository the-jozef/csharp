using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Life_of_man
{
    public class Time
    {
        public static DateTime TimeDate { get; set; } = new DateTime(2025, 11, 29, 10, 0, 0);
        public static int DayCount { get; set; } = 1;
        public static void DrawTimeTopRight(DateTime TimeDate)
        {
            int x = Console.WindowWidth - 15;
            Console.SetCursorPosition(x, 0);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Time: {TimeDate:HH:mm:ss} ");
            
            string day = TimeDate.ToString("dddd", new CultureInfo("en-US")); // den v týždni v angličtine
            string formattedDay = char.ToUpper(day[0]) + day.Substring(1).ToLower();
            
            Console.SetCursorPosition(x + 1, 1);
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

                        if (game.Counting == 0) //oke
                        {
                            if (game.Counting == 100)
                            {
                                Console.SetCursorPosition(0, 2);
                            }
                            else if (game.Counting == 0)
                            {
                                Console.SetCursorPosition("Menu: ".Length, 11);
                            }
                        }
                        else if (game.Counting == 1)
                        {
                            
                        }
                        else if (game.Counting == 2) //oke?
                        {
                            Console.SetCursorPosition("Confirm sleep? (yes/no):".Length + 2, 3);
                        }
                        else if (game.Counting == 3) //oke
                        {
                            Console.SetCursorPosition("Welcome to the shop! Use arrows to navigate, Enter to add ; Backspace to remove and Esc to end.".Length, 2);
                        }
                        else if (game.Counting == 4)
                        { }
                        else if (game.Counting == 5)
                        { }
                        else if (game.Counting == 6)
                        { }
                        else if (game.Counting == 7) //oke?
                        {
                            Console.SetCursorPosition("Set up the hour you want to wake up (0-12):".Length + 1, 3);
                        }
                        else if (game.Counting == 8) //oke
                        {
                            Console.SetCursorPosition("Are you sure you want to end a game? (yes/no):".Length + 2, 11);
                        }
                    }
                };
                timer.AutoReset = true;
                timer.Start();
            }
        }
    }
}


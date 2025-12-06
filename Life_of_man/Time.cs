using System;
using System.Collections.Generic;
using System.Text;

namespace Life_of_man
{
    public class Time
    {
        public static DateTime TimeDate { get; set; } = new DateTime(2025, 11, 29, 10, 0, 0);
        
        public static void DrawTimeTopRight(DateTime TimeDate)
        {
            int x = Console.WindowWidth - 15;
            Console.SetCursorPosition(x, 0);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Time: {TimeDate:HH:mm:ss} ");
            Console.ResetColor();
        }
    }
    public static class UIManager
    {
        public static void StartUI(Player player, DateTime TimeDate, Game game)
        {          
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += (s, e) =>
            {
                Time.TimeDate = Time.TimeDate.AddSeconds(10);

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
                    else if(game.Counting == 1)
                    {
                        Game.ClearLine(2);
                        Console.SetCursorPosition(0, 2);
                        Console.Write("Menu: ");
                    }
                    else if (game.Counting == 2)
                    {
                        Game.ClearLine(2);
                        Console.SetCursorPosition(0, 2);
                        Console.Write("Menu: ");
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
                    else if (game.Counting == 7)
                    { }
                    else if (game.Counting == 8) //oke
                    {
                        Console.SetCursorPosition("Are you sure you want to end a game?".Length + 2,11);
                    }
                }               
            };
            timer.AutoReset = true;
            timer.Start();
        }
    }
}


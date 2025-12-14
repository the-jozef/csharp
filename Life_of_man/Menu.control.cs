using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Life_of_man
{
    public class Menu
    {       
        public static int Counting { get; set; } = 0;
        public static bool MenuControl(Player player,Game game)
        {
            
            int selectedIndex = 0;
            int menuX = 0;
            int menuY = 2;
            int menuItems = 9;

            bool running = true;

            DrawMenu(selectedIndex, menuX, menuY);

            while (running)
            {
                Console.CursorVisible = false;


                ConsoleKeyInfo key = Console.ReadKey(true);
                Console.CursorVisible = false;
                if (key.Key == ConsoleKey.UpArrow && selectedIndex > 0)
                {
                    selectedIndex--;
                    DrawMenu(selectedIndex, menuX, menuY);
                }
                else if (key.Key == ConsoleKey.DownArrow && selectedIndex < menuItems - 1)
                {
                    selectedIndex++;
                    DrawMenu(selectedIndex, menuX, menuY);
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    switch (selectedIndex)
                    {
                        case 0:         // Work (fix if bugs) is done   now on this
                            Counting++;
                            Job.Work(game, player);
                            Counting--;
                            break;

                        case 1:           // Bed (add cw for sleeping new day + alarm clock) is done
                            Counting += 2;
                            Player.Sleeping(new Time());
                            Counting -= 2;
                            break;

                        case 2:            // Supermarket (if bugs + time fix ) is done
                            Counting += 3;
                            Shop.Shopping(player, game);
                            Counting -= 3;
                            break;

                        case 3:           // Inventory (if bugs)is done
                            Counting += 4;
                            Player.ShowInventory(new Shop());
                            Counting -= 4;
                            break;

                        case 4:// Fridge for future no
                            break;

                        case 5:             // Skip time (if bugs)is done
                            Counting += 6;
                            Time.skipTime();
                            Counting -= 6;
                            break;

                        case 6:              // Alarm clock (minutes alarm clock + time PM AM) is done
                            Counting += 7;
                            Player.Alarmclock(new Time());
                            Counting -= 7;
                            break;

                        case 7:// Stats
                            break;

                        case 8:          // End game is done 
                            Counting += 8;
                            Others.EndGame(game);
                            Counting -= 8;
                            running = false;
                            break;
                    }

                    DrawMenu(selectedIndex, menuX, menuY);
                }
            }
            return false;
        }
        static void DrawMenu(int selectedIndex, int x, int y)
        {
            string[] items =
            {
                "1. Work",
                "2. Bed",
                "3. Supermarket",
                "4. Inventory",
                "5. Fridge",
                "6. Skip time",
                "7. Alarm clock",
                "8. Stats",
                "9. End"
            };
  
            // vymaž iba menu oblasť
            for (int i = 0; i < items.Length + 1; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(new string(' ', 30));
            }

            Console.SetCursorPosition(x, y);
            Console.WriteLine("Menu:");

            for (int i = 0; i < items.Length; i++)
            {
                Console.SetCursorPosition(x + 6, y + 1 + i);

                if (i == selectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.WriteLine(items[i]);
            }

            Console.ResetColor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Life_of_man
{
    public class Others
    {
        public static void EndGame(Game game)
        {
            int center = Console.WindowWidth / 2;

            bool running2 = true;
            while (running2)
            {
                Game.ClearLine(11);
                Console.SetCursorPosition(0, 11);
                Console.WriteLine("Are you sure you want to end a game? (yes/no):");
                string answer2 = Console.ReadLine()!;

                if (answer2 == "yes")
                {
                    Game.ClearLine(11);
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("Ending console.......");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.SetCursorPosition(0, 4);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("   ____                                 _                   _                            _               \r\n  / ___|   ___    _ __    ___    ___   | |   ___      ___  | |   ___    ___    ___    __| |            \r\n | |      / _ \\  | '_ \\  / __|  / _ \\  | |  / _ \\    / __| | |  / _ \\  / __|  / _ \\  / _` |            \r\n | |___  | (_) | | | | | \\__ \\ | (_) | | | |  __/   | (__  | | | (_) | \\__ \\ |  __/ | (_| |  _   _   _ \r\n  \\____|  \\___/  |_| |_| |___/  \\___/  |_|  \\___|    \\___| |_|  \\___/  |___/  \\___|  \\__,_| (_) (_) (_)\r\n                                                                                                       ");
                    Console.ResetColor();
                    Environment.Exit(0);
                }
                else if (answer2 == "no")
                {
                    Game.ClearLine(11);
                    Console.WriteLine("You are continuing in game....");
                    Thread.Sleep(2500);
                    running2 = false;
                    Console.Clear();
                    break;
                }
                else
                {
                    Game.ClearLine(11);
                    Console.WriteLine("Invalid code");
                    Thread.Sleep(900);
                    Game.ClearLine(11);
                }
            }
        }
    }
}

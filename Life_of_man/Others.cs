using System;
using System.Collections.Generic;
using System.Text;

namespace Life_of_man
{
    public class Others
    {
        public static void EndGame(Game game)
        {          
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
        public static void Informations()
        {
            Console.Clear();
            Console.WriteLine("You live as 20 years old man who needs to work in programming work in Siemens. You need to wake up every morning to work....");
        }
        public static void Namesetting(Player player)
        {
            Console.Clear();
            
            Console.SetCursorPosition(0, 2);
            Colour.WriteColor("Enter your", ConsoleColor.White);
            Colour.WriteColor(" Name ", ConsoleColor.Red);
            Colour.WriteColor("and", ConsoleColor.White);
            Colour.WriteColor(" Surname: ", ConsoleColor.Red);

            Console.ResetColor();
            Console.CursorVisible = true;
            
            player.FullName = Console.ReadLine()!;
        
            Game.ClearLine(2);
            Console.Write($"Welcome{player.FullName} to ");
            Colour.WriteColor("Life of man game ", ConsoleColor.Magenta);
            Console.Write("!");
            Thread.Sleep(2000);

            Console.ResetColor();
            Console.Clear();
        }
            

    } 
}

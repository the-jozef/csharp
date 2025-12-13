using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Life_of_man
{
    public class Intros
    {
        public static void GameIntro()
        {
            Console.Clear();

            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2;
            
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(centerX - 28 , centerY - 10);
            Console.WriteLine(" ___    __  _____               _____           ");
            Console.SetCursorPosition(centerX - 28 , centerY - 9);
            Console.WriteLine("|   |  |__|/ ____\\____    _____/ ____\\  _____  _____   ___  ");
            Console.SetCursorPosition(centerX - 28 , centerY - 8);
            Console.WriteLine("|   |  |  ||  __\\/ __ \\  /  _ \\   __\\  /     \\ \\__  \\ /   \\ ");
            Console.SetCursorPosition(centerX - 28 , centerY - 7);
            Console.WriteLine("|   |__|  ||  | \\  ___/ (  <_> )  |   |  Y Y  \\/ __ \\|  |  \\");
            Console.SetCursorPosition(centerX - 28 , centerY - 6);
            Console.WriteLine("|_____/\\__||__|  \\___\\   \\____/|__|   |__|_|__(_____/|__|__/");
            Thread.Sleep(500);
                                  
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            string[] lines = new string[]
            {
                "  ____    _                                         ",
                " / ___|  (_)   ___   _ __ ___     ___   _ __    ___ ",
                " \\___ \\  | |  / _ \\ | '_ ` _ \\   / _ \\ | '_ \\  / __|",
                "  ___) | | | |  __/ | | | | | | |  __/ | | | | \\__ \\",
                " |____/  |_|  \\___| |_| |_| |_|  \\___| |_| |_| |___/"
            };
            foreach (var line in lines)
            {
                Console.SetCursorPosition(centerX - 26, Console.CursorTop);
                foreach (char c in line)
                {
                    // Kontrola, či používateľ stlačil Enter
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Enter)
                        {
                            Thread.Sleep(100);
                            Console.Clear();
                            return; // okamžité ukončenie metódy
                        }
                    }
                    Console.Write(c);
                    Thread.Sleep(30);
                }
                Console.WriteLine();
            } 
        }
        public static void Warning()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(); Console.SetCursorPosition(0, 3);

            Console.Write("Warning:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This game can't save a data. After restart you will continue from beginning.");
            Console.Write("        Also this game is in development state and may contain bugs.");
            Thread.Sleep(5000);

            Console.ResetColor();
        }
    }
}

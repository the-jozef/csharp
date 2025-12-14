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
            Console.CursorVisible = false;
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
                    Thread.Sleep(10);
                }
                Console.WriteLine();
            } 
            Thread.Sleep(2000);
            Console.Clear();
        }
        public static void Warning()
        {          
           Console.ForegroundColor = ConsoleColor.DarkRed;
                             
            foreach (char c in $"WARNING:")
            {               
                Console.SetCursorPosition(0, 3);
                foreach (char ch in $"WARNING: This game can't save a data. After restart you will continue from beginning. \r\n         Also this game is in development state and may contain bugs.")
                {                   
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Enter)
                        {
                            Thread.Sleep(100);
                            Console.Clear();
                            Console.ResetColor();
                            return; 
                        }
                    }
                    Console.Write(ch);
                    Thread.Sleep(30);                  
                }
                Thread.Sleep(2000);
                
            }          
                Console.ResetColor();
                Console.Clear();             
        }
    }
}

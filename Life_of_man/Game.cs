using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Text;
using System.Timers;
using System.Xml.Linq;

namespace Life_of_man
{
    public class Game
    {
        public Player Player { get; set; } = new Player();
        public int Counting { get; set; } = 0;
        public void Start()
        {///*
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" ___    __  _____               _____                         \r\n|   |  |__|/ ____\\____    _____/ ____\\   _____ _____    ___  \r\n|   |  |  ||  __\\/ __ \\  /  _ \\   __\\   /     \\\\__  \\  /   \\ \r\n|   |__|  ||  | \\  ___/ (  <_> )  |    |  Y Y  \\/ __ \\|  |  \\\r\n|_____/\\__||__|  \\___\\   \\____/|__|    |__|_|__(_____/|__|__/");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.Write("Warning:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This game can't save a data. After restart you will continue from beginning.");
            Console.Write("        Also this game is in development state and may contain bugs.");
            //Thread.Sleep(15000);   //zapnut neskor + doplnit info o hre
            Console.ResetColor();
            Console.Clear();

            Console.Write("To start a game press any key: ");
            Thread.Sleep(1000);
            Console.ReadKey();
            Console.Clear();

            //Colour.SetColour(); //zapnut neskor
            Console.Clear();

            Console.Write("Set up your character:   Name and Surname: ");
            Player.FullName = Console.ReadLine()!;            
            Console.Clear();

            Console.SetCursorPosition(0, 0);          
            UIManager.StartUI(Player,Time.TimeDate,this);

            //Console.ForegroundColor = Colour.SelectedColor; //zfunkcnit uplne farbu
            //zaciatok hry
            Thread.Sleep(1000);
            //*/
            bool running = true;    
            while(running)
            {             
                ClearLine(2);
                Console.SetCursorPosition(0, 2);                
                
                Console.SetCursorPosition(0, 2);
                Console.Write("Menu: ");
                
                string answer = Console.ReadLine()!;

                switch (answer)   
                {                 
                    case "1":   //job
                        Counting = Counting + 1;
                        Player.Food= Player.Food - 10; 
                        Console.WriteLine();
                        Counting = Counting - 1;
                        break;
                    case "2":  //sleep
                        Counting = Counting + 2;
                        Console.WriteLine();
                        Counting = Counting - 2;
                        break;
                    case "3":  //shop
                        Counting = Counting + 3;
                        ClearLine(2);
                        Shop.Shopping();
                        Counting = Counting - 3;
                        break;
                    case "4":  //inventory pre buducnost 
                        Counting = Counting + 4;
                        Console.WriteLine();
                        Counting = Counting - 4;
                        break;
                    case "5"://fridge
                        Counting = Counting + 5;
                        Console.WriteLine();
                        Counting = Counting - 5;
                        break;
                    case "6":  //skip time
                        Counting = Counting + 6;
                        Console.WriteLine();
                        Counting = Counting - 6;
                        break;
                    case "7":  //alarm clock
                        Counting = Counting + 7;
                        Console.WriteLine();
                        Counting = Counting - 7;
                        break;
                    case "8"://end game make sure button
                        Counting = Counting + 8;
                        Console.WriteLine();
                        Counting = Counting - 8;
                        break;
                            
                }
               // running = false;
            }
        }
        public static void ClearLine(int line)
        {
            int currentLine = Console.CursorTop;
            Console.SetCursorPosition(0, line);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, line);
        }
    }
}  

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
        {
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

            Console.Write("Set up your Name and Surname: ");
            Player.FullName = Console.ReadLine()!;            
            Console.Clear();

            Console.SetCursorPosition(0, 0);          
            Time.UIManager.StartUI(Player,Time.TimeDate,this);

            //Console.ForegroundColor = Colour.SelectedColor; //zfunkcnit uplne farbu
            //zaciatok hry
            Thread.Sleep(1000);
            
            bool running = true;    
            while(running)
            {   
                Counting = 100;
                Console.SetCursorPosition(0, 2);
                Console.WriteLine($" 1 = job \r\n 2 = sleep \r\n 3 = shop \r\n 4= inventory \r\n 5= fridge \r\n 6 = skip time \r\n 7 = alarm clock \r\n 8 = end game");
                Counting = 0;

                //ClearLine(2);                           
                Console.SetCursorPosition(0, 11);
                Console.Write("Menu: ");

                string answer = Console.ReadLine()!;

                switch (answer)
                {
                    case "1":   //job
                        Counting = Counting + 1;
                        Player.Food = Player.Food - 10;
                        Console.WriteLine();
                        Counting = Counting - 1;
                        break;
                    case "2":  //sleep + add cw for sleeping new day
                        Counting = Counting + 2;
                        Player.Sleeping(new Time());
                        Counting = Counting - 2;
                        break;
                    case "3":  //shop fix bugs + inventory fix + add food rationing + add numbers in cart
                        Counting = Counting + 3;
                        ClearLine(2);
                        Shop.Shopping(Player);
                        Counting = Counting - 3;
                        break;
                    case "4":  //inventory in process
                        Counting = Counting + 4;
                        Player.ShowInventory1(new Shop());
                        Counting = Counting - 4;
                        break;
                    case "5"://fridge for future
                        Counting = Counting + 5;
                        Console.WriteLine();
                        Counting = Counting - 5;
                        break;
                    case "6":  //skip time is similiar as sleep but sleep has random waking time and skip will be typed by player
                        Counting = Counting + 6;
                        Console.WriteLine();
                        Counting = Counting - 6;
                        break;
                    case "7":  //alarm clock is done
                        Counting = Counting + 7;
                        Player.Alarmclock(new Time());
                        Counting = Counting - 7;
                        break;
                    case "8"://end game is done
                        Counting = Counting + 8;
                        ClearLine(11);
                        
                        bool running2 = true;
                        while (running2)
                        {
                            Console.SetCursorPosition(0, 11);
                            Console.WriteLine("Are you sure you want to end a game? (yes/no):");
                            string answer2 = Console.ReadLine()!;

                            if (answer2 == "yes")
                            {
                                Console.WriteLine("Ending console.......");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Console closed...");
                                Environment.Exit(0);

                            }
                            else if (answer2 == "no")
                            {
                                ClearLine(11);
                                Console.WriteLine("You are continuing in game....");
                                Thread.Sleep(2500);
                                Console.Clear();
                                Counting = Counting - 8;
                                running2 = false;
                                break;
                            }
                            else
                            {
                                ClearLine(11);
                                Console.WriteLine("Invalid code");
                                Thread.Sleep(900);
                                ClearLine(11);
                            }                          
                        }  
                        break;                                             
                }
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

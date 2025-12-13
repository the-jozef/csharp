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
            
            Intros.GameIntro();

            Intros.Warning();

            /*
                       Console.ResetColor();
                       Console.Clear();

                       //pridat informations

                       Console.Write("To start a game press any key: ");
                       Thread.Sleep(1000);

                       Console.ReadKey();
                       Console.Clear();

                       Colour.SetColour(); //zapnut neskor
                       Console.Clear();

                       Console.Write("Set up your Name and Surname: ");
                       Player.FullName = Console.ReadLine()!;            
                       Console.Clear();*/

            //Console.ForegroundColor = Colour.SelectedColor; //zfunkcnit uplne farbu


            Time.UIManager.StartUI(Player, Time.TimeDate, this);

            
            //zaciatok hry
            Thread.Sleep(1000);

            bool running = true;
            while (running)
            {
                Counting = 100;
                Console.SetCursorPosition(0, 2);
                Console.WriteLine($" 1 = job \r\n 2 = sleep \r\n 3 = shop \r\n 4= inventory \r\n 5= fridge \r\n 6 = skip time \r\n 7 = alarm clock \r\n 8 = end game");
                Counting = 0;
                        
                Console.SetCursorPosition(0, 11);
                Console.Write("Menu: ");

                string answer = Console.ReadLine()!;

                switch (answer)
                {
                    case "1":   //job (fix if bugs) is done
                        Counting = Counting + 1;
                        Job.Work(this,Player);
                        Counting = Counting - 1;
                        break;
                    case "2":  //sleep (add cw for sleeping new day + alarm clock) is done
                        Counting = Counting + 2;
                        Player.Sleeping(new Time());
                        Counting = Counting - 2;
                        break;
                    case "3":  //shop (if bugs + time fix ) is done
                        Counting = Counting + 3;
                        ClearLine(2);
                        Shop.Shopping(Player);
                        Counting = Counting - 3;
                        break;
                    case "4":  //inventory (if bugs)is done
                        Counting = Counting + 4;
                        Player.ShowInventory(new Shop());
                        Counting = Counting - 4;
                        break;
                    case "5"://fridge for future no
                        Counting = Counting + 5;
                        Console.WriteLine();
                        Counting = Counting - 5;
                        break;
                    case "6":  //skip time (if bugs)is done
                        Counting = Counting + 6;
                        Time.skipTime();
                        Counting = Counting - 6;
                        break;
                    case "7":  //alarm clock (minutes alarm clock + time PM AM) is done
                        Counting = Counting + 7;
                        Player.Alarmclock(new Time());
                        Counting = Counting - 7;
                        break;
                    case "8"://end game is done 
                        Counting = Counting + 8;
                        Others.EndGame(this);
                        Counting = Counting - 8;
                        break;
                        //stats about player
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

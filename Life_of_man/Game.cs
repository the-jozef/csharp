using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Linq;

namespace Life_of_man
{
    public class Game
    {
        public Player Player { get; set; } = new Player ();
        public void Start()
        {

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" ___    __  _____               _____                         \r\n|   |  |__|/ ____\\____    _____/ ____\\   _____ _____    ___  \r\n|   |  |  ||  __\\/ __ \\  /  _ \\   __\\   /     \\\\__  \\  /   \\ \r\n|   |__|  ||  | \\  ___/ (  <_> )  |    |  Y Y  \\/ __ \\|  |  \\\r\n|_____/\\__||__|  \\___\\   \\____/|__|    |__|_|__(_____/|__|__/");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.Write("Warning:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This game can't save a data. After restart you will continue from beginning.");
            Console.Write("        Also this game is in development state and may contain bugs.");
            Thread.Sleep(15000);
            Console.ResetColor();
            Console.Clear();
            Console.Write("To start a game press any key: ");
            Thread.Sleep(1000);
            Console.ReadKey();
            Console.Clear();
            //Console.WriteLine("Do you want to change a text color?");
            //dokoncit farbu textu
            Console.Write("Set up your character:   Name:");            
            Player.Name = Console.ReadLine()!;
            Console.Write("                         Surname: ");
            Player.Surname = Console.ReadLine()!;

            //dokoncit nastavenie postavy
            DateTime GameTime = new DateTime(2025, 11, 28, 10, 0,0);  //year,month,day,hour,minute,second
            
            double speed = 2.0;

            while (true)
            {
                // posun času
                GameTime = GameTime.AddSeconds(5 * speed);              

                Thread.Sleep(1000); 
                Console.WriteLine(GameTime.ToString("dd:MM:yyyy:mm"));
             
            }
           







        }
    }
}  

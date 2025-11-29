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

            Colour.SetColour(); 
            Console.Clear();

            Console.Write("Set up your character:   Name and Surname: ");
            Player.FullName = Console.ReadLine()!;            
            Console.Clear();

            Console.SetCursorPosition(0, 0);
            Colour.PlayerStats(Player);           
            
            Time.StartUITimer1();

            Console.ForegroundColor = Colour.SelectedColor;
            //zaciatok hry
            bool running = true;    
            while(running)
            {




            }















        }
    }
}  

using System;
using System.Collections.Generic;
using System.Text;

namespace Life_of_man
{
    public class Game
    {
        public Player Player { get; set; }
        public void Start()
        {
            Console.WriteLine("____    .__  _____                _____                         \r\n|    |   |__|/ ____\\____     _____/ ____\\   _____ _____    ____  \r\n|    |   |  \\   __\\/ __ \\   /  _ \\   __\\   /     \\\\__  \\  /    \\ \r\n|    |___|  ||  | \\  ___/  (  <_> )  |    |  Y Y  \\/ __ \\|   |  \\\r\n|_______ \\__||__|  \\___  >  \\____/|__|    |__|_|  (____  /___|  /\r\n        \\/             \\/                       \\/     \\/     \\/ ");
            Console.Write("To start a game press any key: ");
            Thread.Sleep(1000);
            Console.ReadKey();
            Console.Clear();
            Console.Write("Set your name: ");
            Player.Nam
            Console.Write("Set your surname: ");
            Player.Surname 



        }
    }
}

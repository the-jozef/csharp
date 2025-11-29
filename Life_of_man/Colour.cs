using System;
using System.Collections.Generic;
using System.Text;

namespace Life_of_man
{
    internal class Colour
    {
        public static bool SetColour()
        {
            bool running = true;
            while (running)
            {
                string answer = Console.ReadLine()!;
                if (answer == "yes")
                {
                    Console.WriteLine("Avaiable colours: blue, darkblue, cyan, darkcyan, gray, darkgray, green, darkgreen, magenta, darkmagenta, red, darkred, yellow, darkyellow, white  ");
                    Console.Write("Which colour do you want: ");
                    string answer1 = Console.ReadLine()!;
                    switch (answer1)
                    {
                        case "blue":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            return running;                        
                        case "darkblue":
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            return running;
                        case "cyan":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            return running;
                        case "darkcyan":
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            return running;
                        case "gray":
                            Console.ForegroundColor = ConsoleColor.Gray;
                            return running;
                        case "darkgray":
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            return running;
                        case "green":
                            Console.ForegroundColor = ConsoleColor.Green;
                            return running;
                        case "darkgreen":
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            return running;
                        case "magenta":
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            return running;
                        case "darkmagenta":
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            return running;
                        case "red":
                            Console.ForegroundColor = ConsoleColor.Red;
                            return running;
                        case "darkred":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            return running;
                        case "yellow":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            return running;
                        case "darkyellow":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            return running;                                                                                             
                        case "white":
                            Console.ForegroundColor = ConsoleColor.White;
                            return running;                       
                        default:
                            Console.WriteLine("Typed wrong color name");
                            Thread.Sleep(2000);
                            return running;
                    }
                }
                else if (answer == "no")
                {
                    return running;
                }
                else
                {
                    Console.WriteLine("You typed wrong code....");
                }
            }                                       
            return running;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Life_of_man
{
    public class Colour
    {
        public static ConsoleColor SelectedColor;       
        public static bool SetColour()
        {          
            bool running = true;
            while (running)
            {              
                Console.Write("Do you want to change a text colour? ");
                string answer1 = Console.ReadLine()!;
                
                if (answer1 == "yes")
                {   
                    ColorNumber();                          
                    Console.Write("Which colour do you want: ");
                    string answer2 = Console.ReadLine()!;

                    switch (answer2)
                    {
                        case "0":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.White;
                            return running;                        
                        case "1":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.Blue;
                            return running;
                        case "2":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.DarkBlue;
                            return running;
                        case "3":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.Red;
                            return running;
                        case "4":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.DarkRed;
                            return running;
                        case "5":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.Green;
                            return running;
                        case "6":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.DarkGreen;
                            return running;
                        case "7":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.Yellow;
                            return running;
                        case "8":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.DarkYellow;
                            return running;
                        case "9":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.Magenta;
                            return running;
                        case "10":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            return running;
                        case "11":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.Cyan;
                            return running;
                        case "12":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.DarkCyan;
                            return running;
                        case "13":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.Gray;
                            return running;                                                                                             
                        case "14":
                            SelectedColor = Console.ForegroundColor = ConsoleColor.DarkGray;
                            return running;                       
                        default:
                            Console.WriteLine("Typed wrong color name...");
                            Thread.Sleep(2000);
                            break;
                    }
                }
                else if (answer1 == "no")
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
        public static void ColorNumber()
        {            
            WriteColor("White = ", ConsoleColor.White);
            PrintNumber(0, ConsoleColor.White);

            WriteColor("Blue", ConsoleColor.Blue);
            Console.Write(" = ");
            PrintNumber(1, ConsoleColor.Blue);

            WriteColor("DarkBlue", ConsoleColor.DarkBlue);
            Console.Write(" = ");
            PrintNumber(2, ConsoleColor.DarkBlue);

            WriteColor("Red", ConsoleColor.Red);
            Console.Write(" = ");
            PrintNumber(3, ConsoleColor.Red);

            WriteColor("DarkRed", ConsoleColor.DarkRed);
            Console.Write(" = ");
            PrintNumber(4, ConsoleColor.DarkRed);

            WriteColor("Green", ConsoleColor.Green);
            Console.Write(" = ");
            PrintNumber(5, ConsoleColor.Green);

            WriteColor("DarkGreen", ConsoleColor.DarkGreen);
            Console.Write(" = ");
            PrintNumber(6, ConsoleColor.DarkGreen);

            WriteColor("Yellow", ConsoleColor.Yellow);
            Console.Write(" = ");
            PrintNumber(7, ConsoleColor.Yellow);

            WriteColor("DarkYellow", ConsoleColor.DarkYellow);
            Console.Write(" = ");
            PrintNumber(8, ConsoleColor.DarkYellow);

            WriteColor("Magenta", ConsoleColor.Magenta);
            Console.Write(" = ");
            PrintNumber(9, ConsoleColor.Magenta);

            WriteColor("DarkMagenta", ConsoleColor.DarkMagenta);
            Console.Write(" = ");
            PrintNumber(10, ConsoleColor.DarkMagenta);

            WriteColor("Cyan", ConsoleColor.Cyan);
            Console.Write(" = ");
            PrintNumber(11, ConsoleColor.Cyan);

            WriteColor("DarkCyan", ConsoleColor.DarkCyan);
            Console.Write(" = ");
            PrintNumber(12, ConsoleColor.DarkCyan);

            WriteColor("Gray", ConsoleColor.Gray);
            Console.Write(" = ");
            PrintNumber(13, ConsoleColor.Gray);

            WriteColor("DarkGray", ConsoleColor.DarkGray);
            Console.Write(" = ");
            PrintNumber(14, ConsoleColor.DarkGray);
        }
        public static void PrintNumber(int num, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(num+"\n");
            Console.ResetColor();
        }
        public static void WriteColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();           
        }
        public static void PlayerStats(Player player)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, 0);
            
            WriteColor(player.FullName , ConsoleColor.White);

            WriteColor(" Bank account: ", ConsoleColor.Cyan);
            WriteColor(player.Money + "$  ", ConsoleColor.White);

            WriteColor("Health: ", ConsoleColor.Red);
            WriteColor(Player.Health + "/100  ", ConsoleColor.White);

            WriteColor("Energy: ", ConsoleColor.Green);
            WriteColor(player.Energy + "/100  ", ConsoleColor.White);

            WriteColor("Food: ", ConsoleColor.DarkYellow);
            WriteColor(Player.Food + "/100  ", ConsoleColor.White);

            WriteColor("Thirst: ", ConsoleColor.Blue);
            WriteColor(player.Thirst + "/100", ConsoleColor.White);
            Console.ResetColor();
        }       
    }
}


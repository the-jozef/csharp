using System;

namespace Skusanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random number = new Random();
            int randomNumber = number.Next(1, 101);
       
            Console.WriteLine("Napíš mi nejaké číslo od 1 do 100");
            
            while (true)
            {
                Console.Write("Napis cislo: ");
                int a = int.Parse(Console.ReadLine());

                if (randomNumber > a) //20>15
                {
                    Console.WriteLine("Cislo je vacsie");
                    

                }
                else if (randomNumber < a)
                {
                    Console.WriteLine("Cislo je mensie");
                }
                else if (randomNumber == a)
                {
                    Console.WriteLine("Uhadol si cislo,Gratulujem");
                    break;

                }

            }
            
        }
        
    }
}

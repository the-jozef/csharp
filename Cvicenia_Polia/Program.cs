using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace Cvicenia_Polia
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            int[] c = new int[7];

            c[0] = 2;
            c[1] = 4;
            c[2] = 6;
            c[3] = 5;
            c[4] = 10;
            c[5] = 20;
            /*
            Console.WriteLine(c[1]);
            Console.WriteLine(c[2]);
            Console.WriteLine(c[3]);
            Console.WriteLine(c[4]);
            Console.WriteLine(c[5]);
            Console.WriteLine(c[6]);
           
            int sum = 0;
            
            for (int i = 0; i < c.Length; i++) 
            {
                Console.WriteLine(c[i]);
                sum += c[i];
            }
            Console.WriteLine(sum);
            
            foreach (var number in c)
            {
                sum+= number;
            }
            Console.WriteLine(sum);
            */
            //cyklus pomocou ktoreho naplnime pole cisiel, cez Console.ReadLine
            //spocitanie vsetkych cisiel v poli a vypiseme na konzolu

            int[] numbers = new int[7];
            for (int i = 0; i < c.Length; i++)
             
            
             {
              numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (var number in c)
            {
               sum += number;
               
            }
              Console.WriteLine(sum);

           
            











        }
    }
}

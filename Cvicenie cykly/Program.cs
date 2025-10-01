using System.ComponentModel;
using System.Threading.Channels;

namespace Cvicenie_cykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           //cyklus 1.
            //vypisanie cisiel od 1 do ....
             for (int i = 0; i <= 100; i++)

           { 
               Console.WriteLine(i);

           }


       //vypisanie cisiel od 100 do 0 .....
           for (int i = 100; i >= 0; i--)

           {
               Console.WriteLine(i);

           }
           //jednoduchsie vypisanie
           int rok = 2000;
           Console.WriteLine(rok);
           */
            /*
             //cyklus 2. nekonecny cyklus
               int i = 0;

               while (i < 100)
               { Console.WriteLine("Michal");
                   i++;
               }

               */
            /*
           //cyklus 2 skuska
            Console.WriteLine("Napis mi daco");
            string a = Console.ReadLine();

            while (true)
            {
                if (a == "pozdrav")
                   { Console.WriteLine("Ahoj"); }

                else if (a == "exit")
                { break; }  

                else if (a == "koniec")
                { break ; }
           }
        */
            /*
           while (true)
           {
               while (true)
               {

                   string a = Console.ReadLine();

                   if (a == "exit")
                   {
                       break;

                   }

                   Console.WriteLine("Michal");
               }
               string b = Console.ReadLine();

               if (b == "koniec")
               {
                   break;
               }
               Console.WriteLine("Igor");  
           }
           */
            /*   
          for (int i = 1; i<= 10; i++)
          {
              string row = "";
              for (int j = 1; j <= i ; j++)
              {
                  row += "*";

              }
              Console.WriteLine(row);
          }
          */
            Console.WriteLine("Kolko riadkov chces");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Aky znak?");
            string b = Console.ReadLine();
           

            for (int i = 1; i <= a; i++)
            {
                string row = "";
                for (int j = 1; j <= i; j++)
                {
                    row += b;
                }
                Console.WriteLine(row);
            }

            














            








        }
    }
}

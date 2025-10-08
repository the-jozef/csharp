using System.ComponentModel.Design;

namespace Cvicenia_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ahoj, ako sa volas?");

            string a = Console.ReadLine();

            Console.WriteLine("Ahoj " + a + ", tesi ma.");
            
            Console.WriteLine("Chcel by si si vytvorit pyramidu?");
                
                string b = Console.ReadLine();

            if (b == "ano")
            {
                Console.WriteLine("Zadaj z akeho znaku to chces mat vytvorene?");
                
                string c = Console.ReadLine();

                Console.WriteLine("Na kolko riadkov by si to chcel?");
                int d = int.Parse(Console.ReadLine());
                
                for (int i = 1; i <= d; i++)
                {
                    string row = "";
                    for (int j = 1; j <= i; j++)
                    {
                        row += c;
                    }
                    Console.WriteLine(row);
                }
            }

            else if (b == "nie")
            {
                Console.WriteLine("Nevadi, tak nabuduce");
            }






        }
    }
}
    

                







                
        
    

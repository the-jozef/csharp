using System.IO.Pipes;
using System.Reflection;
using System.Threading.Channels;

namespace Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> list = new List<int>();

            
           while(true)
            { 
                Console.WriteLine("chces pridat cislo napis Add ak nie napis End?");
                string a = Console.ReadLine();
                if (a == "Add") 
                
                {
                    Console.WriteLine("Napis mi ake cisla chces dat");
                    string b = Console.ReadLine();
                    int cislo = int.Parse(b);
                    list.Add(cislo);

                    Console.WriteLine("Napis dalsie cislo do listu");
                    string bb = Console.ReadLine();
                    int cislo2 = int.Parse(bb);
                    list.Add(cislo2);

                }
                
                if (a == "End") 
                {
                    break;

                }



                Console.WriteLine("Chces skontrolovat nejake cislo");
                string n = Console.ReadLine();


                if (n == "ano")
                {
                    Console.WriteLine("A ake cislo chces skontrolovat?");
                    string aaa = Console.ReadLine();
                    int b = int.Parse(aaa);
                    
                    bool bb = list.Contains(b);
                    Console.WriteLine(bb);
                
                }
                if (n == "nie")
                {
                    break;
                }

                Console.WriteLine("Chces vymazat nejake cislo?");
                string c = Console.ReadLine();

                if (c == "ano")
                {
                    Console.WriteLine("Ake cislo?");
                    string aaa = Console.ReadLine();
                    int b = int.Parse(aaa);

                    list.Remove(b);
                }
                
                
                Console.WriteLine("Chces este nejake cislo vymazat?");
                string cc = Console.ReadLine();

                if (cc == "ano")
                {
                    Console.WriteLine("Ake ?");
                    string aaaa = Console.ReadLine();
                    int aaaaaa = int.Parse(aaaa);

                    list.RemoveAt(aaaaaa);
                }

                Console.WriteLine("Chces sucet cisiel?");
                string nn = Console.ReadLine();
              
                Console.WriteLine("Chces vypis cisiel?");
                string ccc = Console.ReadLine();

                if (ccc == "ano")
                {
                    list.ForEach(Console.WriteLine);
                }
            }

        }
    }
}

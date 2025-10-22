using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading.Channels;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> list = new List<int>();

            Console.WriteLine("add (pridat cislo)");
            Console.WriteLine("del (zmazat cislo)");
            Console.WriteLine("delat (zmazat konkretne cislo)");
            Console.WriteLine("has (vypisat zoznam)");
            Console.WriteLine("sort (vypise zoznam od najmensieho cisla)");
            Console.WriteLine("end (ukoncit program)");
            Console.WriteLine("count (napisat sucet vsetkych  cisiel)");
            Console.WriteLine("avg (napisat priemer cisiel)");
            Console.WriteLine("max (napisat najvecsie cislo)");
            Console.WriteLine("min (napisat najmensie cislo)");
            Console.WriteLine("get (napisat cislo na danom indexe)");
            Console.WriteLine("help (vypise vsetky prikazy)");
            Console.WriteLine("adds (pridanie viacej cisiel naraza le musi byt za nimi medzera)");
            Console.WriteLine("cal (spocitanie vsetkych cisiel)");
            
            bool running = true;
            while (running)
             {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        {  
                            string a = Console.ReadLine();
                            int b = int.Parse(a);
                            list.Add(b);
                            break;
                        }
                    case "adds":
                        {
                            string a = Console.ReadLine();
                            string[] r = a.Split(' '); // rozdelí podľa medzery
                            foreach (string c in r)
                            {
                                if (int.TryParse(c, out int cisla))     // bezpečné parsovanie
                                
                                    list.Add(cisla);
                            }                    
                            break;
                        }                  
                    case "del":
                        {
                            string a = Console.ReadLine();
                            int b = int.Parse(a);
                            list.Remove(b);
                            break;
                        }
                    case "delat":
                        { 
                            string a = Console.ReadLine();
                            int b = int.Parse(a);
                            list.RemoveAt(b);
                            break;
                        }
                    case "has":
                        {
                            list.ForEach(Console.WriteLine);
                            
                            break;
                        }
                    case "sort":
                        { 
                            
                            list.Sort();
                            foreach (int number in list)
                            {
                                Console.WriteLine(number);
                            }                          
                            break;
                        }
                    case "count":
                        {
                            int sum = 0;
                            foreach (int count in list) 
                            
                            sum += count;
                            Console.WriteLine(sum);
                            
                            break;
                        }
                    case "avg":
                        {
                            double a = 0;
                            foreach (int avg in list)
                                a += avg;
                                a /= list.Count;
                            Console.WriteLine(a);
                            break;
                        }
                    case "max":
                        {
                            int a = list[0];
                            foreach (int c in list)
                            { if (c > a) 
                                a = c;
                            }      
                            Console.WriteLine(a); 
                            break;
                        }
                        case "min":
                        {
                            int a = list[0];
                            foreach (int c in list)
                            {
                                if (c < a)
                                    a = c;
                            }
                            Console.WriteLine(a);
                            break;
                        }
                        case "get":
                        {
                            string a = Console.ReadLine();
                            int b = int.Parse(a);
                            bool c = list.Contains(b);
                            Console.WriteLine(c);
                            break;
                        }
                        case "cal":
                        {
                            Console.WriteLine("Napis ake znamienko chces");
                            string a = Console.ReadLine();
                            if (a == "+")
                            {
                                int sum = 0;
                                foreach (int count in list)
                                    sum += count;
                                Console.WriteLine(sum);
                            }
                            else if (a == "-")
                            {
                                int sum = 0;
                                foreach (int count in list)
                                    sum -= count;
                                Console.WriteLine(sum);
                            }
                            else if (a == "*")
                            {
                                int sum = 1;
                                foreach (int count in list)
                                    sum *= count;
                                Console.WriteLine(sum);
                            }
                            else if (a == "/")
                            {
                                double sum = list[0];
                                for (int i = 1; i < list.Count; i++)
                                    sum /= list[i];
                                Console.WriteLine(sum);
                            }
                                break;




                        }
                    case "help":
                        {
                            Console.WriteLine("Zoznam:");
                            Console.WriteLine("add (pridat cislo)");
                            Console.WriteLine("del (zmazat cislo)");
                            Console.WriteLine("delat (zmazat konkretne cislo)");
                            Console.WriteLine("has (vypisat zoznam)");
                            Console.WriteLine("sort (vypise zoznam od najmensieho cisla)");
                            Console.WriteLine("end (ukoncit program)");
                            Console.WriteLine("count (napisat sucet vsetkych  cisiel)");
                            Console.WriteLine("avg (napisat priemer cisiel)");
                            Console.WriteLine("max (napisat najvecsie cislo)");
                            Console.WriteLine("min (napisat najmensie cislo)");
                            Console.WriteLine("get (napisat cislo na danom indexe)");
                            Console.WriteLine("help (vypise vsetky prikazy)");
                            Console.WriteLine("adds (pridanie viacej cisiel naraza le musi byt za nimi medzera)");
                            Console.WriteLine("cal (spocitanie vsetkych cisiel)");
                            break;
                        }
                    case "end":
                        {
                            running = false;
                            return;
                        }
                }
            }
        }
    }
}

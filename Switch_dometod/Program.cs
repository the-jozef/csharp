using System.Security.Cryptography.X509Certificates;

namespace Switch_dometod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            
          


            bool running = true;
            while (running)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        {
                            Addnumber(list);
                            break;
                        }
                    case "adds":
                        {
                            
                            Addnumbers(list);
                            break;
                        }
                    case "del":
                        {
                            Delnumbers(list);
                            break;
                        }
                    case "delat":
                        {
                            Delatnumbers(list);
                            break;
                        }
                    case "has":
                        {
                            Hasnumbers(list);
                            break;
                        }
                    case "sort":
                        {
                            Sortnumbers(list);
                            break;
                        }
                    case "count":
                        {
                            Countnumbers(list);
                            break;
                        }
                    case "arg":
                        { 
                        Averagenumbers(list);
                        break;
                        }
                    case "max":
                        {
                            Maxnumbers(list);
                            break;
                        }
                    case "min":
                        {
                            Minnumbers(list);
                            break;
                        }
                    case "get":
                        {
                            Getnumbers(list);
                            break;
                        }
                    case "cal":
                        {
                            Calnumbers(list);
                            break;
                        }
                    case "help":
                        {
                            Helpnumbers(list);
                            break;
                        }
                    case "hass":
                        {
                            Hasnumbers(list);
                            break;
                        }
                    case "end":
                        {
                            running = Endconsol();
                            
                            break;
                        }                
                    default:
                        {
                            break;
                        }
                }
            }
        }
                     
        public static void Addnumber(List<int> list)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);
            list.Add(b);
        }
        public static void Addnumbers(List<int> list)
        {
            string a = Console.ReadLine();
            string[] r = a.Split(' '); // rozdelí podľa medzery
            foreach (string c in r)
            {
                if (int.TryParse(c, out int cisla))     // bezpečné parsovanie

                    list.Add(cisla);
                
            }
        }
        public static void Delnumbers(List<int> list)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);
            list.Remove(b);
        }

        public static void Delatnumbers(List<int> list)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);
            list.RemoveAt(b);
        }

        public static void Hasnumbers(List<int> list)
        {
            list.ForEach(Console.WriteLine);
        }
        public static void Sortnumbers(List<int> list)
        {
            list.Sort();
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
        }
        public static void Countnumbers(List<int> list)
        {
            int sum = 0;
            foreach (int count in list)

                sum += count;
            Console.WriteLine(sum);
        }
        public static void Averagenumbers(List<int> list)
        {
            double a = 0;
            foreach (int avg in list)
                a += avg;
            a /= list.Count;
            Console.WriteLine(a);
        }
        public static void Maxnumbers(List<int> list)
        {
            int a = list[0];
            foreach (int c in list)
            {
                if (c > a)
                    a = c;
            }
            Console.WriteLine(a);
        }
        public static void Minnumbers(List<int> list)
        {
            int a = list[0];
            foreach (int c in list)
            {
                if (c < a)
                    a = c;
            }
            Console.WriteLine(a);
        }
        public static void Getnumbers(List<int> list)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);
            bool c = list.Contains(b);
            Console.WriteLine(c);
        }
        public static void Calnumbers(List<int> list)
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
        }
        public static void Helpnumbers(List<int> list)
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
        }
        public static bool Hasnumbers(List<int> list, int num)
        {
            bool has = false;
            if (list.Contains(num))
            {
                has = true;
            }
            else
            {
                has = false;
            }
            return has;
            return list.Contains(num);
        }
        public static bool Endconsol ()
        {  
            return false;
        }
        
    }
}
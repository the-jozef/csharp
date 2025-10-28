namespace Listsautami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            Console.WriteLine("Napisanim  'help' (vypis commandov)");


            bool running = true;
            while (running)
            {
                string command = Console.ReadLine();

                if (command == "help")
                {
                    Helpcommand(list);
                }
                else if (command == "add")
                {
                    AddCar(list);
                }
                else if (command == "show")
                {
                    Showcsars(list);
                }
                else if (command == "remove")
                {
                    Removecars(list);
                }
                else if (command == "has")
                {
                    Hascars(list);
                }
                else if (command == "end")
                {
                    running = End();
                }
                else if (command == "")
                {

                }
                else
                {
                    Console.WriteLine("Napisal si zle kod");
                }
            }
        }
        public static void AddCar(List<string> list)
        {
            Console.Write("Napis ake auto chces pridat: ");
            string a = Console.ReadLine();
            string[] b = a.Split(";");
            string[] c = a.Split(" ");
            list.Add(a);


            return;
        }
        public static void Helpcommand(List<string> b)
        {
            Console.WriteLine("add (pridat nazov auta)");
            Console.WriteLine("help (vypis commandov)");
            Console.WriteLine("show (prehlad napisanych aut)");
            Console.WriteLine("remove (vymazat auto)");
            Console.WriteLine("end (ukoncit konzolu)");
            Console.WriteLine("has (ci obsahuje auto)");
            Console.WriteLine();
            return;
        }
        public static void Showcsars(List<string> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List je prazdny");
                return;
            }
            else
                foreach (string cars in list)
                {
                    Console.WriteLine(cars);
                    return;
                }
        }
        public static void Removecars(List<string> list)
        {
            Console.WriteLine("Chces vidiet aj zoznam?");
            string answer = Console.ReadLine();
            if (answer == "ano")
            {
                foreach (string cars in list)
                {
                    Console.WriteLine(cars);
                }
                Console.Write("Teraz mozes mazat: ");
                string aa = Console.ReadLine();
                string[] bb = aa.Split(";");
                string[] cc = aa.Split(" ");

                list.Remove(aa);
                return;

            }
            else if (answer == "nie")


                Console.Write("Teraz mozes mazat: ");
            string a = Console.ReadLine();
            string[] b = a.Split(";");
            string[] c = a.Split(" ");

            list.Remove(a);
            return;
        }
        public static void Hascars(List<string> list)
        {
            Console.Write("Napis ci obsahuje: ");
            string a = Console.ReadLine();

            string[] b = a.Split(";");
            string[] c = a.Split(" ");

            if (list.Contains(a))
            {
                Console.WriteLine("Zoznam obsahuje auto");

            }
            else
            {
                Console.WriteLine("Zoznam neobsahuje auto");
                Console.Write("Chcel by si ho pridat? ");
                string aa = Console.ReadLine();
                if (aa == "ano")
                {
                    list.Add(a);
                }
                else if (aa == "nie")
                {
                    return;
                }
            }
            return;
        }
        public static bool End()
        {
            Console.WriteLine("Konzola sa ukoncila");
            return false;


        }
        
    }
}

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> list = new List<int>();

            while (true)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        {
                            string cislotx = Console.ReadLine();
                            int cislo = int.Parse(cislotx);
                            list.Add(cislo);
                            break;
                        }
                    case "end":
                        {
                            break;
                        }
                    default:
                        {
                            break;

                        }

                        //doplnit ostane veci cez case 











                }





























            }
        }
    }
}

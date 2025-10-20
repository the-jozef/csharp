namespace Ulloha_subor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("People_100.csv");

            MoneyCountAverage(text);
            WriteRodneCislo(text);
            MinMoneyCount(text);

            List<string> mojZoznam = PeopleUnder05M(text);
            foreach (string person in mojZoznam)
            {
                Console.WriteLine(person);
            }
            
        }

        public static void MoneyCountAverage(string[] text)
        {
            int sum = 0;
            foreach (string line in text.Skip(1))
            {
                //Martin,Urban,690602/2315,Presov,463102,slobodny
                string[] splits = line.Split(";");
                //prekonvertovanie hodnoty z retazca na cislo
                int accountValue = int.Parse(splits[4]);
                //scitanie int hodnoty so sum-om
                sum += accountValue;
            }
           // Console.WriteLine(sum / (text.Count() - 1));
        }
        public static void WriteRodneCislo(string[] text)
        {
            foreach (string line in text.Skip(1))
            {
                //Martin,Urban,690602/2315,Presov,463102,slobodny
                string[] splits = line.Split(";");
                string birthNumber = splits[3];
                //Console.WriteLine(birthNumber);
            }
        }
        public static void MinMoneyCount(string[] text)
        {
            int minValue = 9999999;
            string minValuePerson = "";
            foreach (string line in text.Skip(1))
            {
                //Martin,Urban,690602/2315,Presov,463102,slobodny
                string[] splits = line.Split(";");
                //prekonvertovanie hodnoty z retazca na cislo
                int accountValue = int.Parse(splits[4]);
                if (accountValue < minValue)
                {
                    minValue = accountValue;
                    minValuePerson = splits[0] + " " + splits[4];
                }
            }
            //Console.WriteLine(minValuePerson);
        }

        //V TEJTO METODE NEMOZE BYT CONSOLE.WRITELINE
        public static List<string> PeopleUnder05M(string[] text)
        {
            //vytvorenie prazdneho listu pre ludi ktory budu mat menej ako 500 000 na ucte
            List<string> peopleWithUnder05M = new List<string>();

            int value = 500000;
            string number = "";
            foreach (string line in text.Skip(1))
            {
                string[] splits = line.Split(";");
                int money = int.Parse(splits[4]);

                if (money < value)
                {
                    money = value;
                    number = splits[4];
                    peopleWithUnder05M.Add(number);

                }
                
                
                //splitnut riadok
                //najst kolko ma na ucte penazi
                //ak ma menej ako 500 000 pridat do listu
            }
            //vrati ti list
            return peopleWithUnder05M;
        }
    }
}
/*string[] subor = File.ReadAllLines("People_100.csv");

/*MoneyCountAverage(text);
WriteRodneCislo(text);
MinMoneyCount(text);

List<string> zoznam = PeopleUnder05M(subor);
            //vypisanie vsetkych ludi zo suboru
        }

        public static void MoneyCountAverage(string[] subor)
{
    int sum = 0;
    foreach (string line in subor.Skip(1))
    {
        //Martin,Urban,690602/2315,Presov,463102,slobodny

        string[] splits = line.Split(";");

        //prekonvertovanie hodnoty z retazca na cislo                
        int accountValue = int.Parse(splits[4]);

        //scitanie int hodnoty so sum-om
        sum += accountValue;
    }
    Console.WriteLine(sum / (subor.Count() - 1));
}
public static void WriteRodneCislo(string[] subor)
{
    foreach (string line in subor.Skip(1))
    {
        //Martin,Urban,690602/2315,Presov,463102,slobodny
        string[] splits = line.Split(";");

        string birthNumber = splits[2];

        Console.WriteLine(birthNumber);
    }
}
public static void MinMoneyCount(string[] subor)
{
    int minValue = 9999999;
    string minValuePerson = "";
    foreach (string line in subor.Skip(1))
    {
        //Martin,Urban,690602/2315,Presov,463102,slobodny
        string[] splits = line.Split(";");

        //prekonvertovanie hodnoty z retazca na cislo
        int accountValue = int.Parse(splits[4]);

        if (accountValue < minValue)
        {
            minValue = accountValue;
            minValuePerson = splits[0] + " " + splits[1];
        }
    }
    Console.WriteLine(minValuePerson);
}

//V TEJTO METODE NEMOZE BYT CONSOLE.WRITELINE
public static List<string> PeopleUnder05M(string[] subor)
{
    //vytvorenie prazdneho listu pre ludi ktory budu mat menej ako 500 000 na ucte
    List<string> people = new List<string>();

    foreach (string line in subor.Skip(1))
    {
        //splitnut riadok
        //najst kolko ma na ucte penazi
        //ak ma menej ako 500 000 pridat do listu
    }

    //vratiti list
    return people;
    */
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Cvicenia_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("People_100.csv");
            numbers(text);
            names(text);

            List<string> list = PeopleUnder05M (text);
            foreach (string person in list)
            {
                Console.WriteLine(person);
            }
        }
        public static void names(string[] text)
        {
            string name = " ";
            foreach (string line in text.Skip(1))
            { 
                string[] splits = line.Split(";");
                string names = splits[0];
                name = splits[0];
               //Console.WriteLine(name);
            }
         }

        public static void numbers(string[] text)
        {
            int value = 1000000000;
            string number = "";
            foreach (string line in text.Skip(1))
            {
                string[] splits = line.Split(";");
                int numbers = int.Parse(splits[4]);

                if (numbers < value)
                {
                    value = numbers;
                    number = splits[4];
                    //Console.WriteLine(number);
                }
            }
        }
                public static List<string> PeopleUnder05M(string[] text)
                 { 
                
                 List<string> peopleWithUnder05M = new List<string>();

                int value = 500000;
                string nameandnumber = "";
            foreach (string line in text.Skip(1))
            {
                string[] splits = line.Split(";");
                int money = int.Parse(splits[4]);

                if (money < value)
                {
                    money = value;
                    nameandnumber = splits[0] + " " + splits[4] ;
                    peopleWithUnder05M.Add(nameandnumber);
                }
            
            }
            
                return peopleWithUnder05M;
            
            
            
        }  
    }
}
    

                







                
        
    

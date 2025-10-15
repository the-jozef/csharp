using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Cvicenia_subor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] text = File.ReadAllLines("People_100.csv");
            moneycount(text);
            

        }
        public static void moneycount(string[] text) 
            {
            int value = 500000;
             string person = "";
             foreach (string line in text.Skip(1))
                {
                  string[] split =line.Split(";");
                  int accountvalue = int.Parse(split[4]);

                if (accountvalue > value)
                {
                    value = accountvalue;
                    person = split[0] +"" +split[4];      
                }             
           }
           Console.WriteLine(person);
        }
    }
}

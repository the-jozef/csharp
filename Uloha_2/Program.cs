using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace Uloha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tem = new List<int> { 3, -1, 12, 7, -3, 0, 19, 14, 2, 5, -5, 8 };
            Writetem(tem);
            Maxtem(tem);
            Mintem(tem);
            Averagetem(tem);
            Averagetem1(tem);
            Tempo(tem);

           
        }
        public static void Writetem(List<int> tem)
        {
            foreach (int i in tem)
            
               Console.Write(i + " ");
               Console.WriteLine();
            
        }
        public static void Maxtem(List<int> tem)
        {
            //max
            int a = tem[0];
            foreach (int c in tem)
            {
                if (c > a)
                    a = c;
            }
            Console.WriteLine(a);

        }
        public static void Mintem(List<int> tem)
        {
            //min
            int b = tem[0];
            foreach (int c in tem)
            {
                if (c < b)
                    b = c;
            }
            Console.WriteLine(b);
        }
        public static void Averagetem(List<int> tem)
        {
            //priemer
            double d = 0;
            foreach (int avg in tem)
            
                d += avg;
                d /= tem.Count;
            
            Console.WriteLine(d);
        }
        public static void Averagetem1(List<int> tem)
        {
            double d = 0;
            foreach (int avg in tem)
                d += avg;
            d /= tem.Count;

            int n = 0;
            foreach (var a in tem)
            {
                if (a > d)
                {
                    n = n + 1;
                    n++;
                }
            }
            Console.Write(n);
            Console.WriteLine();


         }
         public static void Tempo(List<int> tem)
          {
            List<int> tempos = new List<int>();
            foreach (int tems in tem)
            {
                if (tems > 0)
                {
                  tempos.Add(tems);
                }
            }
            foreach (int i in tempos)
            {
                Console.Write(i + " ");
                
            }
             Console.WriteLine();
            
            
            
                        




        }
      
        
    }
}

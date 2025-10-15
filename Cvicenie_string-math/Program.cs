using System.Reflection.Metadata.Ecma335;
using System.Runtime;

namespace Cvicenie_string_math
{
    internal class Program
    {
        static void Main(string[] args)
         
        {
           
            Console.WriteLine("napis mi cislo");
            string m =Console.ReadLine();
            int n = int.Parse(m);
           
            Console.WriteLine("napis mi dalsie cislo");
            string mm = Console.ReadLine();
            int nn = int.Parse(mm);
            
            int sum = scitanie(nn ,n ,15,5 ,5);
            
            Console.WriteLine(sum);
        }
       
        public static int scitanie (int nn, int n, int c, int d,int f)
        
        {
           
            
            int aa = n + nn + c + d + f;
            return aa;
           
        
        
        
        
        
        
        
        
        }
    

    }
}

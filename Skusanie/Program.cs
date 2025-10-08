namespace Skusanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aa= new int[10];
            
            for   (int i = 0; i < aa.Length; i++) 
                {
                 aa[i] = i * 10;

                }

            int[] cc = new int[11];

            for (int i = 0; i < aa.Length; i++)
            {
                cc[i] = aa[i];
            }
            cc[10] = 100;
            foreach (int i in cc)
            {
                Console.WriteLine(i);
            }
            












        }
    }
}

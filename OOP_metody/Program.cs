using System.Security.Cryptography.X509Certificates;

namespace OOP_metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Richard Ciprich";
            string Adress = "Stara Bystrica 602";
            int Age = 15;
           

            string Namea = "Marek Arendarik";
            string Adressa = "Rakova 1259";
            string Agea = "15";
            

            Student student = new Student();
            student.Age = Age;
            student.Name = Name;
            student.Adress = "Kyjev";
            student.Gender = 'M';



            Student student2 = new Student();
            student2.Age = 100;
            student2.Name = "Markus";
            student2.Adress = "Moskwa";
            student2.Gender = 'G';

            Student starystudent = student;
            starystudent.Name += "Peter Novak";
            //Console.WriteLine(starystudent.Name);

            
            

            //Console.WriteLine(student2.Isadult() );
            Console.WriteLine(student.Test());

            

           
            
        }
    }
}

namespace Cvicenie_Pravdepodobnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*Random number = new Random();
            int value = number.Next(0,101);

            if (value < 60)
            {
                Console.WriteLine("Vyhral ten s 80%");
            }
            else if (value >)
            {
                Console.WriteLine("Vyhral ten s 40%");
            }
            else if ()
            {
            }*/

            Student student = new Student("Michal",5);
            Student student2 = new Student("Igor",15);
            Student student3 = new Student("Matus",25);
            Student student4 = new Student("Leonardo",55);

            List<Student> students = new List<Student>();
            students.Add(student);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            //students.Add(new Student("Rudo", 1);

            List<Student> Hat = new List<Student>();
            foreach(Student stud in students)
            {
                for (int i = 0; i < stud.TicketCount; i++)
                {
                    Hat.Add(stud);
                }
            }
            Random random = new Random();
            int chance = random.Next(Hat.Count);
            Student winner = Hat[chance];
            Console.WriteLine($"{winner.Id} {winner.TicketCount}");

        }
    }
}

namespace Random_number_cvicenie
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname; 
        }  
        public void Write()
        {
            Console.WriteLine("Volam sa: " + Name +" " + Surname);
        }


    }
}

using System.Security.Cryptography.X509Certificates;

namespace Random_number_cvicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Random random = new Random();
             int number = random.Next(0,5);
             double numberr = random.Next();
              double c = number + numberr;
              double cc = number * 5;
              Console.WriteLine(c);
              Console.WriteLine(cc);
              */
            Random r = new Random();
          
            
            
            var femaleFirstNames = new List<string>
            {
                "Anna","Mária","Katarína","Zuzana","Lucia","Kristína","Monika","Veronika","Lenka","Petra",
                "Michaela","Eva","Jana","Jarmila","Martina","Barbora","Adriana","Alexandra","Alžbeta","Alica",
                "Daniela","Diana","Dominika","Natália","Nikola","Nikoleta","Silvia","Simona","Ivana","Iveta",
                "Ingrid","Renáta","Gabriela","Miriam","Pavlína","Laura","Karolína","Klára","Tatiana","Tereza",
                "Beáta","Bianka","Rebeka","Nela","Ema","Ela","Tamara","Viktória","Zora","Žaneta"
            };

            var maleFirstNames = new List<string>
            {
                "Peter","Martin","Jozef","Tomáš","Lukáš","Jakub","Michal","Marek","Andrej","Anton",
                "Samuel","Dominik","Richard","Róbert","Roman","Patrik","Filip","Juraj","Karol","Daniel",
                "Dávid","Adam","Erik","Igor","Ivan","Ľubomír","Pavol","Stanislav","Štefan","Matej",
                "Matúš","Vladimír","Viliam","Radovan","Rastislav","Šimon","Sebastián","Eduard","Marián","Gabriel",
                "Tobiáš","Boris","Alan","Oliver","Oskar","Leonard","Viktor","Alex","Benjamin","Tadeáš"

            };
            var femaleSurnamesSk = new List<string>
            {
                "Nováková","Horváthová","Kováčová","Vargová","Tóthová","Nagyová","Molnárová","Szabóová","Lukáčová","Kučerová",
                "Poláková","Kráľová","Urbanová","Krajčíová","Kováčiková","Kubišová","Holubová","Benková","Blašková","Mareková",
                "Tomášová","Balážová","Farkašová","Bartošová","Šimková","Pavlíková","Michalíková","Černáková","Švecová","Ševčíková",
                "Juríková","Hrušková","Chovancová","Rácová","Hudáková","Ondrušová","Sokolová","Pospíšilová","Gašparová","Gregorová",
                "Valentová","Ďuricová","Ďurišová","Vavrová","Žáková","Koreňová","Červeňová","Šramková","Mrázová","Mrvová"
            };

            var maleSurnamesSk = new List<string>
            {
                "Novák","Horváth","Kováč","Varga","Tóth","Nagy","Molnár","Szabó","Lukáč","Kučera",
                "Polák","Kráľ","Urban","Krajčí","Kováčik","Kubiš","Holub","Benko","Blaško","Marek",
                "Tomáš","Baláž","Farkaš","Bartoš","Šimko","Pavlík","Michalík","Černák","Švec","Ševčík",
                "Jurík","Hruška","Chovanec","Rác","Hudák","Ondruš","Sokol","Pospíšil","Gašpar","Gregor",
                "Valent","Ďurica","Ďuriš","Vavro","Žák","Koreň","Červeň","Šramko","Mráz","Mrva"
            };


            string manname = Randomstring(maleFirstNames,r);
            string mansurname = Randomstring(maleSurnamesSk,r);

            string femalename = Randomstring(femaleFirstNames,r);
            string femalesurname = Randomstring(femaleSurnamesSk,r);

            Person man = new Person(manname,mansurname);
            Person female = new Person(femalename,femalesurname);

            female.Write();
            man.Write();

            //Console.WriteLine("muz"+manname +" " + mansurname);
            //Console.WriteLine("zena"+femalename + " " + femalesurname);
        }
        public static string Randomstring(List<string> strings, Random r)
        {
            int count = strings.Count;
            int index = r.Next(count);
            string name = strings[index];
            return name;
        }
    }
}


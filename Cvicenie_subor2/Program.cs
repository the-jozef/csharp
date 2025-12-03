using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace Cvicenie_subor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Napis co treba:  ");  
               
                string command = Console.ReadLine(); 
                Console.WriteLine();
                string file = "Player.txt";
                
              

                if (command == "write")
                {
                    Player player = new Player("Igor", 17);
                    Player player1 = new Player("Miso", 18);
                    Player player2 = new Player("Riso", 8);
                    List<Player> people = new List<Player>();
                    
                    //List<string> Player = new List<string>();
                   
                    people.Add(player);
                    people.Add(player1);
                    people.Add(player2);

                    string json = JsonSerializer.Serialize(people);

                    File.WriteAllText(file, json);

                    //string linepl = player.Informations();
                    //File.WriteAllText(file,linepl);
                }
                if (command == "read")
                {
                    if(!File.Exists(file))
                    {
                        Console.WriteLine("FIle exists");
                        return;
                    }
                    string wholefile = File.ReadAllText(file);

                    List<Player> people = JsonSerializer.Deserialize<List<Player>>(wholefile);


                    foreach(Player o in people)
                    {


                    }
                    /*
                    string[] read = File.ReadAllLines(file);

                    List<Player> people = new List<Player>();

                    foreach (var line in read)
                    {
                        string[] PlayerArr = line.Split(",");
                        string name = PlayerArr[0];
                        int age = int.Parse(PlayerArr[1]);

                        people.Add(new Player(name, age));

                        Console.WriteLine($"{name} ma {age} rokov.");                        

                        Player readedplayer = new Player(name, age);
                    */
                    }                   
                }
            }
        }
    }
}

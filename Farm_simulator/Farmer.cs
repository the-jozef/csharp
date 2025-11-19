using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Farm_simulator
{
    public class Farmer
    {
        public Random RandomGenerator { get; set; } = new Random();          
        public int Day { get; set; }
        public int Wallet { get; set; } = 10;
        public List<Plant> Field { get; set; } = new List<Plant>();

        public List<Plant> Storage { get; set; } = new List<Plant> ();

        public void StartGame()
        {                      
            while (true)
            {
               Day++;                 
                       
                foreach(var plant in Field)
                {
                    plant.TimeInGround++;
                }  
                
                foreach(var plant in Field)
                {
                    Console.WriteLine("Field:");
                    Console.WriteLine(plant);
                }
                List<Plant> HarvestPlants = new List<Plant> ();

                foreach(var plant in Field)
                {
                    if (plant.TimeInGround >= plant.TimeForHarvest)
                    {
                        Console.WriteLine(plant.PlantType + " has grown a full size");
                        HarvestPlants.Add(plant);
                    }
                }

                foreach (var plant in HarvestPlants)
                {
                    Field.Remove (plant);
                    Storage.Add (plant);
                }
                
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Info:");
                Console.WriteLine("Days: "+ Day + "  Money: " + Wallet + "$");         
                
                Console.WriteLine("Menu: " );
                Console.WriteLine("Enter for new day: ");
                Console.WriteLine("Add plant: 1");
                Console.WriteLine("Show storage: 2");
                Console.WriteLine("Sell storage: 3");

                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Which plant do you want to grow?");
                        Console.WriteLine("1 Corn for " + 5 +  "$");
                        Console.WriteLine("2 Orange for "+ 10 + " $");
                        Console.WriteLine("3 Cucumber for 20$");
                        Console.WriteLine("4 Grapes for 26$");
                        Console.WriteLine("5 Zucchiny for 50$");
                        
                        string? answer = Console.ReadLine();
                        if (answer == "1")
                        { 
                            int Cornprice = 5;  

                            Plant corn = new Plant("Corn", 5, 10); //price = predajna hodnota ,   price2(ine meno) = nakupna hodnota
                            if (corn.Price <= Wallet)
                            {
                                Field.Add(corn);
                            }
                            else
                            {
                                Console.WriteLine("Mas nedostatok penazi");
                                Thread.Sleep(1000);
                            }
                            //corn.Price = corn.Price + 1;
                        }
                        else if (answer == "2")
                        {
                            Plant orange = new Plant("Grapes", 8, 15);
                            Field.Add(orange);
                        }
                        else if (answer == "3")
                        {
                            Plant cucumber = new Plant("Cucumber", 10, 22);
                            Field.Add(cucumber);
                        }
                        else if (answer == "4")
                        {
                            Plant grapes = new Plant("Grapes", 15, 27);
                            Field.Add(grapes);
                        }
                        else if (answer == "5")
                        {
                            Plant pzucchini = new Plant("Premium zuciciny", 100, 50);
                            Field.Add(pzucchini);
                        }
                        break;
                    case "2":
                        foreach (Plant plant in Storage)
                        {
                            Console.WriteLine(plant);
                            Thread.Sleep(1000);

                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        foreach (var plant in Storage)
                        {
                            Wallet = plant.Price * Storage.Count;
                           
                        }
                        Storage.Clear();
                        break;
                    case "4":

                        break;
                    default:
                        break;
                }              
                Console.Clear();
               
            }                          
        }
    }
}

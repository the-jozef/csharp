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
        public Random RandomGen { get; set; } = new Random();          
        public int Day { get; set; }
        public int Wallet { get; set; } = 10;
        public List<Plant> Field { get; set; } = new List<Plant>();

        public List<Plant> Storage { get; set; } = new List<Plant> ();

        public void StartGame()
        {                      
            while (true)
            {
               Day++;                 
                
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Field:");       
               
                foreach(var plant in Field)
                {
                    plant.TimeInGround++;
                }  
                
                foreach(var plant in Field)
                {
                    
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
                        Console.WriteLine("1 Corn for 5$");
                        Console.WriteLine("2 Orange for 10$");
                        Console.WriteLine("3 Cucumber for 20$");
                        Console.WriteLine("4 Grapes for 26$");
                        Console.WriteLine("5 Zucchiny for 50$");
                        
                        string? answer = Console.ReadLine();
                        if (answer == "1")
                        {                           
                            Plant corn = new Plant ("Corn", 5, 12,10); 
                            if (corn.PlantPrice <= Wallet)
                            {
                                Field.Add(corn);
                                Wallet = Wallet - corn.PlantPrice;
                            }
                            else
                            {
                                Console.WriteLine("You don't have that much money");
                                Thread.Sleep(1000);
                            }
                            corn.PlantPrice = corn.PlantPrice + RandomGen.Next(1,3);
                        }
                        else if (answer == "2")
                        {
                            Plant orange = new Plant ("Grapes", 9, 20, 15);
                            if (orange.PlantPrice <= Wallet)
                            {
                                Field.Add(orange);
                                Wallet = Wallet - orange.PlantPrice;
                            }
                            else
                            {
                                Console.WriteLine("You don't have that much money");
                                Thread.Sleep(1000);
                            }              
                            orange.PlantPrice = orange.PlantPrice + RandomGen.Next(1, 4);
                        }
                        else if (answer == "3")
                        {
                            Plant cucumber = new Plant ("Cucumber", 13, 25, 20);
                            if (cucumber.PlantPrice <= Wallet)
                            {
                                Field.Add(cucumber);
                                Wallet = Wallet - cucumber.PlantPrice;
                            }
                            else
                            {
                                Console.WriteLine("You don't have that much money");
                                Thread.Sleep(1000);
                            }                         
                            cucumber.PlantPrice =  1 + cucumber.PlantPrice * RandomGen.Next(1, 2);
                        }
                        else if (answer == "4")
                        {
                            Plant grapes = new Plant("Grapes", 20, 30 ,27);
                            if (grapes.PlantPrice <= Wallet)
                            {
                                Field.Add(grapes);
                                Wallet = Wallet - grapes.PlantPrice;
                            }
                            else
                            {
                                Console.WriteLine("You don't have that much money");
                                Thread.Sleep(1000);
                            }                     
                            grapes.PlantPrice = 1 + grapes.PlantPrice * RandomGen.Next(1, 3);
                        }
                        else if (answer == "5")
                        {
                            Plant pzucchini = new Plant ("Premium zuciciny", 100, 80 ,70);
                            if (pzucchini.PlantPrice <= Wallet)
                            {
                                Field.Add(pzucchini);
                                Wallet = Wallet - pzucchini.PlantPrice;
                            }
                            else
                            {
                                Console.WriteLine("You don't have that much money");
                                Thread.Sleep(1000);
                            }              
                            pzucchini.PlantPrice = pzucchini.PlantPrice + RandomGen.Next(1, 6);
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
                            Wallet = Wallet + (plant.SalePrice * RandomGen.Next(1, 4));
                           
                        }
                        Storage.Clear();
                        break;
                    case "":
                    
                        
                    default:                       
                        break;
                }              
                Console.Clear();
               
            }                          
        }
    }
}

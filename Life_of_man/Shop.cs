using System;
using System.Collections.Generic;
using System.Text;

namespace Life_of_man
{
    internal class Shop
    {
        public string ItemName { get; set; }
        public int FoodPrice { get; set; }
        public int DrinkPrice { get; set; }

        public static bool Shopping()
        {
            Console.WriteLine("You'r driving to a shop....");
            Thread.Sleep(1000);

            Time.TimeDate = Time.TimeDate.AddMinutes(30);

            Console.WriteLine("It took you 30 minutes....");
            Thread.Sleep(1000);
            
            Console.WriteLine("Welcome to the shop! What would you like to buy?");
            Console.WriteLine("1. Food - 10$");
            Console.WriteLine("2. Drink - 5$");
            Console.WriteLine("3. Exit Shop");
            bool shopping = true;
            while (shopping)
            {
                string choice = Console.ReadLine()!;
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You bought some food.");

                        break;
                    case "2":
                        Console.WriteLine("You bought a drink.");

                        break;
                    case "3":
                        shopping = false;
                        Console.WriteLine("Thank you for visiting the shop!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;


                }
            }
            return true;
        }
        public static List<Shop> items()
        {
            var result = new List<Shop>();
            {

            }
     
            return result;
        }
     
    }
}

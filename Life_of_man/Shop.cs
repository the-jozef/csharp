using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Xml.Linq;

namespace Life_of_man
{
    internal class Shop
    {
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"{ItemName} (Hodnota: {Price}";
        }
        public static bool Shopping()
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("You'r driving to a shop....");
            Thread.Sleep(1500);

            Time.TimeDate = Time.TimeDate.AddMinutes(30);
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("It took you 30 minutes....");
            Thread.Sleep(1500);
            Console.Clear();

            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Welcome to the shop! What would you like to buy?");
            foreach (var item in items())
            {
               // Console.SetCursorPosition(0, 4);
                Console.WriteLine($"{item.ItemName} - {item.Price} coins");
            }
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
                        Console.Clear();
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
            var item = new List<Shop>();
            {
                item.Add(new Shop { ItemName = "Bread", Price = 5 });
                item.Add(new Shop { ItemName = "Water", Price = 2 });
                item.Add(new Shop { ItemName = "Apple", Price = 3 });
                item.Add(new Shop { ItemName = "Sandwich", Price = 7 });
                item.Add(new Shop { ItemName = "Milk", Price = 3 });
                item.Add(new Shop { ItemName = "Banana", Price = 2 });
                item.Add(new Shop { ItemName = "Orange", Price = 3 });
                item.Add(new Shop { ItemName = "Chicken", Price = 10 });
                item.Add(new Shop { ItemName = "Beef", Price = 12 });
                item.Add(new Shop { ItemName = "Pasta", Price = 5 });
                item.Add(new Shop { ItemName = "Tomato", Price = 2 });
                item.Add(new Shop { ItemName = "Cucumber", Price = 2 });
                item.Add(new Shop { ItemName = "Lettuce", Price = 3 });
                item.Add(new Shop { ItemName = "Yogurt", Price = 3 });
                item.Add(new Shop { ItemName = "Coffee", Price = 6 });
                item.Add(new Shop { ItemName = "Tea", Price = 4 });
                item.Add(new Shop { ItemName = "Soda", Price = 3 });
                item.Add(new Shop { ItemName = "Beer", Price = 5 });
                item.Add(new Shop { ItemName = "Wine", Price = 12 });
                item.Add(new Shop { ItemName = "Chocolate", Price = 4 });
                item.Add(new Shop { ItemName = "Cookies", Price = 3 });
                item.Add(new Shop { ItemName = "Ice Cream", Price = 5 });
                item.Add(new Shop { ItemName = "Cereal", Price = 6 });
                item.Add(new Shop { ItemName = "Nuts", Price = 7 });
                item.Add(new Shop { ItemName = "Honey", Price = 8 });
                item.Add(new Shop { ItemName = "Jam", Price = 5 });
                item.Add(new Shop { ItemName = "Carrot", Price = 2 });
                item.Add(new Shop { ItemName = "Potato", Price = 2 });
                item.Add(new Shop { ItemName = "Onion", Price = 2 });
                item.Add(new Shop { ItemName = "Garlic", Price = 3 });
                item.Add(new Shop { ItemName = "Strawberry", Price = 5 });
                item.Add(new Shop { ItemName = "Blueberry", Price = 6 });
                item.Add(new Shop { ItemName = "Lemon", Price = 3 });
                item.Add(new Shop { ItemName = "Coconut Water", Price = 5 });
                item.Add(new Shop { ItemName = "Smoothie", Price = 6 });
                item.Add(new Shop { ItemName = "Burger", Price = 8 });
                item.Add(new Shop { ItemName = "Fries", Price = 4 });
                item.Add(new Shop { ItemName = "Pizza", Price = 9 });
                item.Add(new Shop { ItemName = "Pancakes", Price = 5 });
                item.Add(new Shop { ItemName = "Bagel", Price = 4 });
                item.Add(new Shop { ItemName = "Donut", Price = 3 });
                item.Add(new Shop { ItemName = "Watermelon", Price = 7 });
                item.Add(new Shop { ItemName = "Grapes", Price = 6 });
                item.Add(new Shop { ItemName = "Apple Juice", Price = 4 });
                return item;
            }
        }
    }
}

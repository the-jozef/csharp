using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Xml.Linq;

namespace Life_of_man
{
    internal class Shop
    {
        public int Quantity { get; set; } = 1;
        public int number { get; set; }
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"{Quantity}x {ItemName} - Price: {Price}$";
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
            Console.WriteLine("Welcome to the shop! Use arrows to navigate, Enter to add.");

            Console.WriteLine();
            int x = Console.WindowWidth - "Items in your cart:  ".Length;
            Console.SetCursorPosition(x, 2);

            int startIndexItems = 0;
            int startIndexCart = 0;
            int pageSize = 20;
            int selectedIndexItems = 0;
            int selectedIndexCart = 0;
            bool focusCart = false;
            bool running = true;

            var items = Shop.items();
            var cart = new List<Shop>();



            ConsoleKeyInfo key;

            int leftX = 0; // hlavný zoznam
            int rightX = Console.WindowWidth - 25; // košík
            int startY = 4;

            while (running)
            {
                Console.Clear();

                Console.SetCursorPosition(leftX, startY - 2);
                Console.WriteLine("Items:");

                for (int i = 0; i < pageSize && startIndexItems + i < items.Count; i++)
                {
                    Console.SetCursorPosition(leftX, startY + i);

                    if (!focusCart && startIndexItems + i == selectedIndexItems)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    Console.WriteLine($"{startIndexItems + i + 1}. {items[startIndexItems + i].ItemName} - {items[startIndexItems + i].Price}$");
                }

                Console.ResetColor();
                int GetCartValue()
                {
                    int sum = 0;
                    foreach (var item in cart)
                        sum += item.Price * item.Quantity;

                    return sum;
                }
                Console.SetCursorPosition(rightX + 8, startY - 2);
                Console.Write($"Cart: (Value: {GetCartValue()}$)");

                for (int i = 0; i < pageSize && startIndexCart + i < cart.Count; i++)
                {
                    Console.SetCursorPosition(rightX, startY + i);

                    if (focusCart && startIndexCart + i == selectedIndexCart)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    var citem = cart[startIndexCart + i];
                    Console.WriteLine($"{citem.Quantity}x {citem.ItemName} - {citem.Price * citem.Quantity}$");
                }

                Console.ResetColor();

                key = Console.ReadKey(true);

                if (!focusCart)
                {
                    if (key.Key == ConsoleKey.DownArrow && selectedIndexItems < items.Count - 1)
                    {
                        selectedIndexItems++;
                        if (selectedIndexItems >= startIndexItems + pageSize)
                            startIndexItems++;
                    }
                    else if (key.Key == ConsoleKey.UpArrow && selectedIndexItems > 0)
                    {
                        selectedIndexItems--;
                        if (selectedIndexItems < startIndexItems)
                            startIndexItems--;
                    }
                    else if (key.Key == ConsoleKey.RightArrow && cart.Count > 0)
                    {
                        focusCart = true;
                        // ak už máš vybraný index v košíku, uisti sa, že je v platnom rozsahu
                        if (selectedIndexCart >= cart.Count) selectedIndexCart = cart.Count - 1;
                        if (selectedIndexCart < 0) selectedIndexCart = 0;
                        // nastav startIndexCart tak, aby bol selectedIndexCart viditeľný
                        if (selectedIndexCart < startIndexCart) startIndexCart = selectedIndexCart;
                        if (selectedIndexCart >= startIndexCart + pageSize) startIndexCart = selectedIndexCart - pageSize + 1;
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        var selected = items[selectedIndexItems];
                        var existing = cart.FirstOrDefault(x => x.ItemName == selected.ItemName);

                        if (existing != null)
                            existing.Quantity++;
                        else
                            cart.Add(new Shop { ItemName = selected.ItemName, Price = selected.Price, Quantity = 1 });
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.DownArrow && selectedIndexCart < cart.Count - 1)
                    {
                        selectedIndexCart++;
                        if (selectedIndexCart >= startIndexCart + pageSize)
                            startIndexCart++;
                    }
                    else if (key.Key == ConsoleKey.UpArrow && selectedIndexCart > 0)
                    {
                        selectedIndexCart--;
                        if (selectedIndexCart < startIndexCart)
                            startIndexCart--;
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        focusCart = false;
                    }
                    else if (key.Key == ConsoleKey.Backspace)
                    {
                        if (cart.Count > 0 && selectedIndexCart >= 0 && selectedIndexCart < cart.Count)
                        {
                            var item = cart[selectedIndexCart];

                            // ak je viac kusov, len zníž množstvo
                            if (item.Quantity > 1)
                            {
                                item.Quantity--;
                            }
                            else
                            {
                                // inak úplne odstrán položku
                                cart.RemoveAt(selectedIndexCart);

                                // uprav selectedIndexCart (bezpečne)
                                if (selectedIndexCart >= cart.Count)
                                    selectedIndexCart = cart.Count - 1;
                            }

                            // ak sa košík vyprázdnil, nechceme zostať vo focusCart
                            if (cart.Count == 0)
                            {
                                focusCart = false;
                                selectedIndexCart = 0;
                                startIndexCart = 0;
                            }
                            else
                            {
                                // oprav prípadné negatívne indexy
                                if (selectedIndexCart < 0) selectedIndexCart = 0;
                                // ak selected vyšiel nad start, uprav start tak, aby bol selected viditeľný
                                if (startIndexCart > selectedIndexCart) startIndexCart = selectedIndexCart;
                                if (selectedIndexCart >= startIndexCart + pageSize) startIndexCart = selectedIndexCart - pageSize + 1;
                            }
                        }
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("Thank you for visiting the shop!");
                        Thread.Sleep(3500);
                        running = false;
                    }
                }
                
            }
            Console.Clear();
            return false;
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
        public static void ShowCart(List<Shop> cart)
        {            
            foreach (var item in cart)
            {
                int x = Console.WindowWidth - 67;
                Console.SetCursorPosition(x, Console.CursorTop);
                Console.WriteLine(item.ToString());
            }
        }
    }
}

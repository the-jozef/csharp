namespace Cvicenie_Gameshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Item> items = LootGenerator.GetRandomLoot();
           
            Item best = items[0];
            foreach( var item in items)
            {
                if (item.Price > best.Price)
                {
                    best = item;
                }
            }
            Console.WriteLine(best);  
            Item worst = items.MinBy(item => item.Price);
           // Console.WriteLine(worst);

            Item best1 = items.MaxBy(item => item.Price);
            //Console.WriteLine(best1);
            List<Item> orederBy = items.OrderBy(item => item.Price).ToList();
            Console.WriteLine(orederBy[0]);

            List<Item> orderbybest = items.OrderByDescending(item => item.Price).ToList();
            Console.WriteLine($"best item: {orderbybest[0]}");

            List<Item> under1000= items.Where(item => item.Price >= 500 && item.Price <= 1000).ToList();
            Console.WriteLine($"count under 1000$ and more 500$: {under1000.Count}");
            
            

        }
    }    
}

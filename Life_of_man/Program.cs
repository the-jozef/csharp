namespace Life_of_man
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Menu menu = new Menu();
            Shop shop = new Shop();
            game.Start(menu,shop);
        }
    }
}

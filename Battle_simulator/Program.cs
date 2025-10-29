namespace Battle_simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero ourHero = new Hero();
            Monster monster = new Monster("Goblin",150,5);

            //Console.WriteLine(ourHero.HP);
            //Console.WriteLine(monster.HP);

            //ourHero.HP = ourHero.HP - monster.DMG;

            //Console.WriteLine(ourHero.HP);
            while (true)
            {
                monster.Monstereffect(ourHero);
                Console.WriteLine("Hero HP: " + ourHero.HP);

               // ourHero.Heroeffect(monster);
                bool Attack = ourHero.Heroeffect(monster);



                if (Attack)
                {
                    Console.WriteLine("Monster HP: " + monster.HP);
                }
                else 
                {
                    Console.WriteLine("Not enought energy to attack. Restoring energz.....");
                    Console.WriteLine("Hero energy: " + ourHero.ENG);
                }
                
                
                
                if (ourHero.HP == 0)
                {
                    Console.WriteLine("Hero is dead");
                    break;
                
                }
                else if (monster.HP == 0)               
                {
                    Console.WriteLine("Monster is dead");
                    break;
                }

                //armor
            }

            
        }
    }
}

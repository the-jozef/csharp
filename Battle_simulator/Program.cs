using Battle_simulator;
using System.Threading;

namespace Battle_simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero ourHero = new Hero();
            Monster monster = new Monster("Goblin", 100, 5);
            Monster2 monster2 = new Monster2("Orc", 150, 10);
            Monster3 monster3 = new Monster3("Dark elf", 200, 8);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Ready to fight!");
                Thread.Sleep(1000);
                Console.WriteLine();
                
                bool battle = Battle(ourHero, monster,monster2,monster3);

               // ourHero.RegenAll(ourHero);
                
                //Console.WriteLine();
                //Console.WriteLine("Ready to a second fight!");
                //Thread.Sleep(1500);
                //Console.WriteLine();
                
               // bool battle2 = Battle2(monster2, ourHero);
                return;
            }
        }
       
        public static bool Battle (Hero ourHero, Monster monster,Monster2 monster2,Monster3 monster3)
        {
            Console.WriteLine("If you will kill Goblin you win");
            
            Console.WriteLine("Hero HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor " + ourHero.ARMOR);
            Console.WriteLine(monster.Racetype + " HP: " + monster.HP);

            bool running = true;
            while (running)
            {
                monster.Monstereffect(ourHero);
                Console.WriteLine($"{monster.Racetype} dealed {monster.DMG} DMG on {ourHero.Name}");
                monster2.Monstereffect(ourHero);
                Console.WriteLine($"{monster2.Racetype} dealed {monster2.DMG} DMG on {ourHero.Name}");
                monster3.Monstereffect(ourHero);
                Console.WriteLine($"{monster3.Racetype} dealed {monster3.DMG} DMG on {ourHero.Name}");

                bool Attack = ourHero.Heroattack(monster);
                if (Attack)
                {
                    if (monster.HP <= 0)
                    {
                        monster.HP = 0;

                        Console.WriteLine("You dealed the highest dammage.");
                        Thread.Sleep(800);
                        monster2.HP = monster2.HP - monster2.HP;
                        monster3.HP = monster3.HP - monster3.HP;
                        Console.WriteLine("You killed all enemies.");
                        Thread.Sleep(1000);

                        Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                        Console.WriteLine(monster2.Racetype + " HP " + monster2.HP);
                        Console.WriteLine(monster3.Racetype + " HP " + monster3.HP);

                        Console.WriteLine("Hero" + " HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor: " + ourHero.ARMOR);

                        //Console.WriteLine(monster.Racetype + " is dead");

                        return true;
                    }
                    if (ourHero.HP <= 0)
                    {
                        ourHero.HP = 0;
                        Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                        Console.WriteLine("Hero" + " HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor: " + ourHero.ARMOR);

                        Console.WriteLine("Hero" + " is dead");
                        Thread.Sleep(1000);
                        Console.WriteLine("You lost the GAME");
                        Thread.Sleep(1000);
                        return false;
                    }
                    if (ourHero.ENG < 20)
                    {
                        Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                        Console.WriteLine("Hero" + " HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor: " + ourHero.ARMOR);
                        ourHero.EnergyRegen(monster);
                        Console.WriteLine("Not enought energy to attack. Restoring energy.....");
                        Console.WriteLine("Energy restored: " + ourHero.ENG);
                    }
                    else
                        Console.WriteLine("Hero" + " HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor: " + ourHero.ARMOR);

                        Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                }    
                    

            }
                return false;
        }
        
        
        
        /*public static bool Battle(Hero ourHero, Monster monster)
        {
            Console.WriteLine("Hero HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor " + ourHero.ARMOR);
            Console.WriteLine(monster.Racetype + " HP: " + monster.HP);

            bool running = true;
            while (running)
            {
                monster.Monstereffect(ourHero);
                Console.WriteLine("Hero HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor " + ourHero.ARMOR);

                bool Attack = ourHero.Heroattack(monster);
                if (Attack)
                {
                    if (monster.HP <= 0)
                    {
                        monster.HP = 0;
                        Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                        Console.WriteLine("Hero" + " HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor: " + ourHero.ARMOR);

                        Console.WriteLine(monster.Racetype + " is dead");
                        Thread.Sleep(1000);
                        return true;
                    }
                    if (ourHero.HP <= 0)
                    {
                        ourHero.HP = 0;
                        Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                        Console.WriteLine("Hero" + " HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor: " + ourHero.ARMOR);

                        Console.WriteLine("Hero" + " is dead");
                        Thread.Sleep(1000);
                        Console.WriteLine("You lost the GAME");
                        Thread.Sleep(1000);
                        return false;
                    }
                    if (ourHero.ENG < 20)
                    {
                        Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                        Console.WriteLine("Hero" + " HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor: " + ourHero.ARMOR);
                        ourHero.EnergyRegen(monster);
                        Console.WriteLine("Not enought energy to attack. Restoring energy.....");
                        Console.WriteLine("Energy restored: " + ourHero.ENG);
                    }
                    else
                        Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                        monster.DMG = monster.DMG + 5;
                        //Console.WriteLine("Hero" + " HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor: " + ourHero.ARMOR);
                }
            }
            return true;
        }
        public static bool Battle2(Monster2 monster2, Hero ourHero)
        {
            Console.WriteLine("Hero HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor " + ourHero.ARMOR);
            Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);

            bool running = true;
            while (running)
            {
                monster2.Monstereffect(ourHero);
                Console.WriteLine("Hero HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor " + ourHero.ARMOR);

                bool Attack = ourHero.Heroattack2(monster2);
                if (Attack)
                {
                    if (monster2.HP <= 0)
                    {
                        monster2.HP = 0;
                        Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);
                        Console.WriteLine("Hero" + " HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor: " + ourHero.ARMOR);

                        Console.WriteLine(monster2.Racetype + " is dead");
                        Thread.Sleep(1000);
                        return true;
                    }
                    if (ourHero.HP <= 0)
                    {
                        ourHero.HP = 0;
                        Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);
                        Console.WriteLine("Hero"+ " HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor: " + ourHero.ARMOR);

                        Console.WriteLine("Hero" + " is dead");
                        Thread.Sleep(1000);
                        Console.WriteLine("You lost the GAME");
                        Thread.Sleep(1000);
                        return false;
                    }
                    if (ourHero.ENG < 20)
                    {
                        Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);
                        Console.WriteLine("Hero" + " HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor: " + ourHero.ARMOR);
                        ourHero.EnergyRegen2(monster2);
                        Console.WriteLine("Not enought energy to attack. Restoring energy.....");
                        Console.WriteLine("Energy restored: " + ourHero.ENG);
                    }
                    else
                        Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);
                        //Console.WriteLine("Hero" + " HP: " + ourHero.HP + " ENG: " + ourHero.ENG + " Armor: " + ourHero.ARMOR);
                }
            }
            return true;
        }*/
    } 
}
        
    


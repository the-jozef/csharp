using System.Threading;

namespace Battle_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("To start a game type start: ");
            string? a = Console.ReadLine();
            if (a == "start")
            {

            }
            else 
            {
                return;
            }
            
            Hero hero = new Hero();
            Monster monster = new Monster("Goblin", 1, 1000);
            Monster2 monster2 = new Monster2("Dark wizard", 150, 20, 150);

            Console.Write("Set your hero name: ");
            string? name = Console.ReadLine();
            hero.Name = name;
            while (true)
            {
                Console.Write("While you are walking you saw a Goblin,do you want to attack it? ");
                string? answer = Console.ReadLine();
                      
                if (answer == "yes")
                {
                    Console.WriteLine("Ready to fight!");
                    bool heroalive = Battle(monster, hero, monster2);
                    Console.WriteLine("Ready to a second fight!");
                    bool heroalive2 = Battle2(monster2, hero);
                    return;
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Monster appeared behind you and killed you");
                    Thread.Sleep(800);
                    return;
                }
                else
                {
                    Console.WriteLine("You typed wrong code,try again");
                    Thread.Sleep(1000);
                }
            }
        }
        public static bool Battle(Monster monster, Hero hero,Monster2 monster2)
        {
            Console.WriteLine(hero.Name + " HP: " + hero.HP +" ENG " + hero.ENG + " Mana " + hero.Mana);
            
            bool running = true;
            while (running)           
            {
                if (monster.HP < 0)
                {
                    monster.HP = 0;
                    return false;
                }
                if (hero.HP < 0)
                {
                    hero.HP = 0;
                    break;
                }

                bool Attack = hero.HeroAttack(monster);
                if (Attack)
                {
                    if (monster.HP < 0 )
                    {
                        monster.HP = 0;
                        return true;
                    }
                    if (hero.HP < 0)
                    {
                        hero.HP = 0;
                        break;
                    }   
                    Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                    monster.MonsterAttack(hero);
                    Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana); 
                }
                else
                {
                    Console.WriteLine("Not enought energy to attack. Restoring energy.....");
                    Console.WriteLine("Energy restored: " + hero.ENG);

                }
                bool FireAttack = hero.FireAttack(monster);
                if (FireAttack)
                {
                    if (monster.HP < 0 )
                    {
                        monster.HP = 0;
                        break;
                    }
                    if (hero.HP < 0)
                    {
                        hero.HP = 0;
                        return true;
                    }
                    Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                    monster.MonsterAttack(hero);
                    Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);
                }
                else if (hero.Mana <=35)
                {
                    Console.WriteLine("Not enought mana to attack. Restoring mana.....");
                    Console.WriteLine("Mana restored: " + hero.Mana);
                }               
                if (hero.HP <= 0)
                {
                    Console.WriteLine("Hero is dead");
                    break;
                }
                if (monster.HP <= 0)
                {
                    Console.WriteLine(monster.Racetype + " is dead");
                    Console.Write(monster2.Racetype + " appeared.Do you want to attack him? ");
                    string? answer= Console.ReadLine();
                    if (answer == "yes")
                    {
                        return true;
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine(monster2.Racetype + " casted a spell and killed you");
                        Thread.Sleep(800);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("You typed wrong code,try again");
                        
                    }
                }            
            }    
            return false;
        }
        public static bool Battle2(Monster2 monster2, Hero hero)
        {
            bool running2 = true;
            while (running2)
            {
                monster2.MonsterAttack(hero);
                Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

                bool Attack = hero.HeroAttack2(monster2);
                bool FireAttack = hero.FireAttack2(monster2);

                if (FireAttack)
                {

                    Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);
                }
                else
                {
                    Console.WriteLine("Not enought mana to attack. Restoring mana.....");
                    Console.WriteLine("Mana restored: " + hero.Mana);
                }

                if (Attack)
                {
                    Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);
                }
                else
                {
                    Console.WriteLine("Not enought energy to attack. Restoring energy.....");
                    Console.WriteLine("Energy restored: " + hero.ENG);

                }
                if (hero.HP <= 0)
                {
                    Console.WriteLine("Hero is dead");
                    break;
                }
                else if (monster2.HP == 0)
                {
                    Console.WriteLine(monster2.Racetype + " is dead");
                    Console.WriteLine("The END");
                    Thread.Sleep(800);
                    break;
                }
            }
         return false;
        }
    }
}

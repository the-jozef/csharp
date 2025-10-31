using System;
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
            Monster monster = new Monster("Goblin", 8, 100);
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
                    Console.WriteLine();
                    Console.WriteLine("Ready to fight!");
                    bool battle = Battle(monster, hero, monster2);

                    bool deadmonster = Death(monster, monster2, hero);

                    Console.WriteLine();
                    Console.WriteLine("Ready to a second fight!");
                    bool battle2 = Battle2(monster2, hero);
                    return;
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Monster appeared behind you and killed you");
                    Thread.Sleep(1500);
                    return;
                }
                else
                {
                    Console.WriteLine("You typed wrong code,try again");
                    Thread.Sleep(2000);
                }
            }
        }
        public static bool Battle(Monster monster, Hero hero, Monster2 monster2)
        {
            Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

            bool running = true;
            while (running)
            {

                bool Attack = hero.HeroAttack(monster);
                if (Attack)
                {
                    monster.MonsterAttack(hero);

                    if (monster.HP <= 0)
                    {
                        monster.HP = 0;
                        Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                        Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

                        Console.WriteLine(monster.Racetype + " is dead");
                        Thread.Sleep(1000);
                        return true;
                    }
                    if (hero.HP <= 0)
                    {
                        hero.HP = 0;
                        Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                        Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

                        Console.WriteLine(hero.Name + " is dead");
                        Thread.Sleep(1000);
                        return false;
                    }
                    if (hero.ENG < 20)
                    {
                        Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                        Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);
                        hero.EnergyRegen2(monster2);
                        Console.WriteLine("Not enought energy to attack. Restoring energy.....");
                        Console.WriteLine("Energy restored: " + hero.ENG);
                    }
                    else
                        Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                    Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

                    bool FireAttack = hero.FireAttack(monster);
                    if (FireAttack)
                    {
                        monster.MonsterAttack(hero);

                        if (monster.HP <= 0)
                        {
                            monster.HP = 0;
                            Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                            Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

                            Console.WriteLine(monster.Racetype + " is dead");
                            Thread.Sleep(1000);
                            return true;
                        }
                        if (hero.HP < 0)
                        {
                            hero.HP = 0;
                            Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                            Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

                            Console.WriteLine(hero.Name + " is dead");
                            Thread.Sleep(1000);
                            return false;
                        }
                        if (hero.Mana < 35)
                        {
                            Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                            Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);
                            hero.ManaRegen(monster);
                            Console.WriteLine("Not enought mana to attack. Restoring mana.....");
                            Console.WriteLine("Mana restored: " + hero.Mana);
                        }
                        else
                            Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                        Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);
                    }
                }
            }
            return true;
        }
        public static bool Death(Monster monster, Monster2 monster2, Hero hero)
        {
            bool running = true;
            while (running)
            {
                if (hero.HP == 0)
                {
                    break;
                }
                else if (monster.HP == 0)
                {
                    Console.Write(monster2.Racetype + " appeared.Do you want to attack him? ");
                    string? answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        return true;
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine(monster2.Racetype + " casted a spell and killed you");
                        Thread.Sleep(800);
                        break;
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
            Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

            bool running = true;
            while (running)
            {
                bool Attack2 = hero.HeroAttack2(monster2);
                if (Attack2)
                {
                    monster2.MonsterAttack(hero);

                    if (monster2.HP <= 0)
                    {
                        monster2.HP = 0;
                        Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);
                        Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

                        Console.WriteLine(monster2.Racetype + " is dead");
                        Thread.Sleep(1000);

                        Console.WriteLine("The END");
                        Thread.Sleep(1000);
                        return true;
                    }
                    if (hero.HP <= 0)
                    {
                        hero.HP = 0;
                        Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);
                        Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

                        Console.WriteLine(hero.Name + " is dead");
                        Thread.Sleep(1000); 
                        Console.WriteLine("You lost the GAME");
                        Thread.Sleep(1000);
                        break;
                    }
                    if (hero.ENG < 20)
                    {
                        Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);
                        Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);
                        hero.EnergyRegen2(monster2);
                        Console.WriteLine("Not enought energy to attack. Restoring energy.....");
                        Console.WriteLine("Energy restored: " + hero.ENG);
                    }
                    else
                        Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);
                        Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

                    bool FireAttack2 = hero.FireAttack2(monster2);
                    if (FireAttack2)
                    {
                        monster2.MonsterAttack(hero);

                        if (monster2.HP <= 0)
                        {
                            monster2.HP = 0;
                            Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);
                            Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

                            Console.WriteLine(monster2.Racetype + " is dead");
                            return true;
                        }
                        if (hero.HP < 0)
                        {
                            hero.HP = 0;
                            return false;
                        }
                        if (hero.Mana < 35)
                        {
                            Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);
                            Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);
                            hero.ManaRegen2(monster2);
                            Console.WriteLine("Not enought mana to attack. Restoring mana.....");
                            Console.WriteLine("Mana restored: " + hero.Mana);
                        }
                        else
                            Console.WriteLine(monster2.Racetype + " HP: " + monster2.HP);
                            Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);
                    }
                }
            }
            return true;
        }
    }
}
        
    
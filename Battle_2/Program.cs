using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Battle_2
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("To start a game type start: ");
            Thread.Sleep(800);
            string? a = Console.ReadLine();

            if (a == "start")
            {
            }
            else
            {
                //return;
            }

            Hero hero = new Hero();
            Monster monster = new Monster ("Goblin", 8, 1000);
            Monster2 monster2 = new Monster2 ("Dark wizard", 150, 20, 150);

            Console.Write("Set your hero name: ");
            Thread.Sleep(800);
            hero.Name = Console.ReadLine();

            bool spendingpoints = SpendingPoints(hero);
            Console.Clear();

            while (true)
            {
                Console.Write("While you are walking you saw a Goblin,do you want to attack it? ");
                Thread.Sleep(1000);
                string? answer = Console.ReadLine();

                if (answer == "yes")
                {
                    Console.Clear();
                    Console.WriteLine("Ready to a fight!");
                    Console.WriteLine();

                    bool battle = Battle(monster, hero, monster2);
                    Console.Clear();

                    bool deadmonster = Death(monster, monster2, hero);
                    Console.Clear();

                    Console.Clear();
                    Console.WriteLine("Ready to a second fight!");
                    Console.WriteLine();
                    
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
                    Thread.Sleep(1500);
                }
            }
        }
        public static bool SpendingPoints(Hero hero)
        {

            Console.WriteLine($"You have {hero.Points} free points. Where do you want to spend them?");
            Thread.Sleep(1200);
            Console.WriteLine("1 point is 5 value ");
            Thread.Sleep(1000);
            {
                Console.WriteLine("1--> Damage");
                Console.WriteLine("2--> Healt");
                Console.WriteLine("3--> Energy");
                Console.WriteLine("4--> Mana");
                Console.WriteLine("5--> Fire damage");
                Console.WriteLine("0--> End spending");
            }
            Thread.Sleep(800);

            bool running = true;
            while (running)
            {
                if (hero.Points == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("No remaining points. New points can be recieved by killing enemies");
                    Thread.Sleep(2500);
                    return false;
                }
                Console.WriteLine();
                Console.Write("Which number: ");
                string? a = Console.ReadLine();

                Console.Write("How many points: ");
                string? b = Console.ReadLine();
                int value = int.Parse(b);
                Console.WriteLine();

                switch (a)
                {
                    case "1":                                                                        
                        if (value <= hero.Points && hero.Points > 0)  
                        {
                            hero.DMG = hero.DMG + (5 * value);                         
                            hero.Points = hero.Points - value;

                            Console.WriteLine("Your new damage is " + hero.DMG);
                            Thread.Sleep(800);
                            Console.WriteLine($"Now you have {hero.Points} points.");
                            Thread.Sleep(800);
                        }
                        else if (value > hero.Points)
                        {
                            Console.WriteLine("You don't have enough points");
                            Thread.Sleep(800);
                        }
                        else if (hero.Points < 0)
                        {
                            Console.WriteLine("You can't type negative number");
                            Thread.Sleep(800);
                        }
                        break;
                    case "2":
                        if (value<= hero.Points && hero.Points > 0)
                        {
                            hero.HP = hero.HP + (5 * value);
                            hero.MaxHP = hero.HP;
                            hero.Points = hero.Points - value;

                            Console.WriteLine("Your new healt is " + hero.HP);
                            Thread.Sleep(800);
                            Console.WriteLine($"Now you only have {hero.Points} points.");
                            Thread.Sleep(800);
                        }
                        else if (value > hero.Points)
                        {
                            Console.WriteLine("You don't have enough points");
                            Thread.Sleep(800);
                        }
                        else if (hero.Points < 0)
                        {
                            Console.WriteLine("You can't type negative number");
                            Thread.Sleep(800);
                        }
                        break;
                    case "3":
                        if (value<= hero.Points && hero.Points > 0)
                        {
                            hero.ENG = hero.ENG + (5 * value);
                            hero.MaxENG = hero.ENG;
                            hero.Points = hero.Points - value;

                            Console.WriteLine("Your new maximum energy is " + hero.ENG);
                            Thread.Sleep(800);
                            Console.WriteLine($"Now you only have {hero.Points} points.");
                            Thread.Sleep(800);
                        }                        
                        else if (value > hero.Points)
                        {
                            Console.WriteLine("You don't have enough points");
                            Thread.Sleep(800);
                        }
                        else if (hero.Points < 0)
                        {
                            Console.WriteLine("You can't type negative number");
                            Thread.Sleep(800);
                        }
                        break;
                    case "4":
                        if (value <= hero.Points && hero.Points > 0)
                        { 
                            hero.Mana = hero.Mana + (5 * value);
                            hero.MaxMana = hero.Mana;
                            hero.Points = hero.Points - value;

                            Console.WriteLine("Your new maximum mana is " + hero.Mana);
                            Thread.Sleep(800);
                            Console.WriteLine("Now you only have " + value + " points.");
                            Thread.Sleep(800);                                                                       
                        }                        
                        else if (value > hero.Points)
                        {
                            Console.WriteLine("You don't have enough points");
                            Thread.Sleep(800);
                        }
                        else if (hero.Points < 0)
                        {
                            Console.WriteLine("You can't type negative number");
                            Thread.Sleep(800);
                        }
                        break;
                    case "5":
                        if (value <= hero.Points && hero.Points > 0)
                        {
                            hero.FireDMG = hero.FireDMG + (5 * value);
                            hero.Points = hero.Points - value;

                            Console.WriteLine("Your new fire damage is " + hero.FireDMG);
                            Thread.Sleep(800);
                            Console.WriteLine("Now you only have " + value + " points.");
                            Thread.Sleep(800);
                        }                                      
                        else if (value > hero.Points)
                        {
                            Console.WriteLine("You don't have enough points");
                            Thread.Sleep(800);
                        }
                        else if (hero.Points < 0)
                        {
                            Console.WriteLine("You can't type negative number");
                        }
                        break;
                    case "0":
                            Console.WriteLine("You ended spending points");
                            Thread.Sleep(1000);
                        return false;
                    default:
                            Console.WriteLine("You typed wrong code,try again");
                            Thread.Sleep(1000);
                            continue;
                }
            }
            return false;
        }                
        public static bool Battle(Monster monster, Hero hero, Monster2 monster2)
        {
            {  
                Console.WriteLine("Type a number which attack do you want to perform.");
                Console.WriteLine("1--> Melle attack");
                Console.WriteLine("2--> Restore energy");
                Console.WriteLine("3--> Fire attack (50% chance)");
                Console.WriteLine("4--> Restore mana");
                Console.WriteLine("5--> Block");
                Console.WriteLine("6--> Info");
                Console.WriteLine($"7--> Info about {hero.Name}");
            }
            Thread.Sleep(800);
            Console.WriteLine();

            int count = 0;

            Console.Write("Which type of attack do you want to perform: ");
            bool running = true;
            while (running)
            {
                if(count == 4)
                {
                    Console.Clear();
                    Console.Clear();
                    Console.WriteLine("Ready to a fight!");
                    Console.WriteLine();
                    {
                        Console.WriteLine("Type a number which attack do you want to perform.");
                        Console.WriteLine("1--> Melle attack");
                        Console.WriteLine("2--> Restore energy");
                        Console.WriteLine("3--> Fire attack (50% chance)");
                        Console.WriteLine("4--> Restore mana");
                        Console.WriteLine("5--> Block");
                        Console.WriteLine("6--> Info");
                        Console.WriteLine($"7--> Info about {hero.Name}");
                    }
                    Thread.Sleep(800);
                    Console.WriteLine();
                    Console.Write("Which type of attack: ");
                    Thread.Sleep(900);
                }
                string? attacktype = Console.ReadLine();
                Console.WriteLine();
                switch (attacktype)
                {
                    case "1":
                        if (hero.ENG < 20)
                        {
                            Console.Write("You don't have enought energy. Do you want to restore it?  ");
                            string? answer = Console.ReadLine();

                            if (answer == "yes")
                            {
                                Console.WriteLine("Restoring your energy...");
                                Thread.Sleep(800);
                                
                                hero.EnergyRegen(monster);

                                Console.WriteLine();
                                Console.WriteLine("New:");
                                Console.WriteLine("Energy restored: " + hero.ENG);
                                
                                monster.MonsterAttack(hero);
                                Console.WriteLine(hero);
                                Thread.Sleep(800);
                                break;
                            }
                            if (answer == "no")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You typed wrong answer. Try again.");
                            }
                        }
                        bool Attack = hero.HeroAttack(monster); 
                        if (Attack)
                        {
                            monster.MonsterAttack(hero);  

                            if (monster.HP <= 0)
                            {
                                monster.HP = 0;
                                Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                                Console.WriteLine(hero);

                                Console.WriteLine(monster.Racetype + " is dead");
                                Thread.Sleep(1000);
                                return true;
                            }
                            if (hero.HP <= 0)
                            {
                                hero.HP = 0;
                                Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                                Console.WriteLine(hero);

                                Console.WriteLine(hero.Name + " is dead");
                                Thread.Sleep(1000);
                                Console.WriteLine("You lost the GAME");
                                Thread.Sleep(1000);
                                Environment.Exit(0);
                            }
                            else
                                Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                                Console.WriteLine(hero);
                        }                       
                        break;
                    case "2":
                        Console.WriteLine("Restoring your energy....");
                        Thread.Sleep(800);
                        
                        hero.EnergyRegen(monster);

                        Console.WriteLine();
                        Console.WriteLine("New:");
                        Console.WriteLine("Energy restored: " + hero.ENG);

                        monster.MonsterAttack(hero);            
                        
                        Console.WriteLine(hero);                        
                        Thread.Sleep(800);
                        break;
                    case "3":
                        if (hero.Mana < 35)
                        {
                            Console.Write("You don't have enought mana. Do you want to restore it?  ");
                            string? answer = Console.ReadLine();

                            if (answer == "yes")
                            {
                                Console.WriteLine("Restoring your mana...");
                                Thread.Sleep(800);

                                hero.ManaRegen(monster);

                                Console.WriteLine();
                                Console.WriteLine("New:");
                                Console.WriteLine("Mana restored: " + hero.Mana);       
                                
                                monster.MonsterAttack(hero);
                                Console.WriteLine(hero);
                                Thread.Sleep(800);
                                break;
                            }
                            if (answer == "no")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You typed wrong answer. Try again.");
                            }                                
                        }
                        bool FireAttack = hero.FireAttack(monster);
                        if (FireAttack)
                        {
                            monster.MonsterAttack(hero);

                            if (monster.HP <= 0)
                            {
                                monster.HP = 0;
                                Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                                Console.WriteLine(hero);

                                Console.WriteLine(monster.Racetype + " is dead");
                                Thread.Sleep(1000);
                                return true;
                            }
                            if (hero.HP <= 0)
                            {
                                hero.HP = 0;
                                Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                                Console.WriteLine(hero);

                                Console.WriteLine(hero.Name + " is dead");
                                Thread.Sleep(1000);
                                Console.WriteLine("You lost the GAME");
                                Thread.Sleep(1000);
                                return false;
                            }
                            else
                                Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                                Console.WriteLine(hero);
                                break;
                        }
                        Console.WriteLine("Fire attack didn't work.");
                        Console.WriteLine();

                        monster.MonsterAttack(hero);

                        Console.WriteLine(hero);
                        break;
                    case "4":                                              
                        Console.WriteLine("Restoring your mana.....");
                        Thread.Sleep(800);

                        hero.ManaRegen(monster);

                        Console.WriteLine();
                        Console.WriteLine("New:");
                        Console.WriteLine("Mana restored: " + hero.Mana);

                        monster.MonsterAttack(hero);
                        Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                        Console.WriteLine(hero);                      
                        Thread.Sleep(800);
                        break;
                    case "5":

                        break;
                    case "6":
                        {
                            Console.WriteLine("1--> Melle attack");
                            Console.WriteLine("2--> Restore energy");
                            Console.WriteLine("3--> Fire attack (50% chance)");
                            Console.WriteLine("4--> Restore mana");
                            Console.WriteLine("5--> Block");
                            Console.WriteLine("6--> Info");
                            Console.WriteLine($"7--> Info about {hero.Name}");
                        }
                        Thread.Sleep(800);
                        break;
                    case "7":
                        {
                            Console.WriteLine($"Stats about {hero.Name}");
                            Console.WriteLine($"Melee damage: {hero.DMG}  Fire damage: {hero.FireDMG}  Block:"); //doplnit                                                   
                            Console.WriteLine(hero);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You typed wrong code. Try again.");
                            Thread.Sleep(800);
                            break;
                        }
                }
                Console.WriteLine();
                Console.Write("Which type of attack: ");
                Thread.Sleep(900);
                count++;
            }
            return false;
        }                            
        
        //dokoncit
        
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
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("You typed wrong code,try again");
                        Thread.Sleep(1000);
                    }
                }
            }
            return false;            
        }
        public static bool Battle2(Monster2 monster2, Hero hero)
        {
            Console.WriteLine(hero);

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
        
    
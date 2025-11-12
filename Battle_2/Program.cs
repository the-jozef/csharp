using System;
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
            Monster monster = new Monster("Goblin", 8, 100);
            Monster2 monster2 = new Monster2("Dark wizard", 150, 20, 150);

            Console.Write("Set your hero name: ");
            Thread.Sleep(800);
            hero.Name = Console.ReadLine();

            bool spendingpoints = SpendingPoints(hero);

            while (true)
            {
                Console.Write("While you are walking you saw a Goblin,do you want to attack it? ");
                Thread.Sleep(1000);
                string? answer = Console.ReadLine();

                if (answer == "yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("Ready to fight!");
                    Console.WriteLine();
                    bool battle = Battle(monster, hero, monster2); //tu

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
                    Thread.Sleep(1500);
                }
            }
        }
        public static bool SpendingPoints(Hero hero)
        {
            Console.WriteLine("You have 5 free points. Where do you want to spend them?");
            Thread.Sleep(1200);
            Console.WriteLine("You must type a number and how much points do you want to spend.");
            Thread.Sleep(1500);
            Console.WriteLine("1 point is 10 value ");
            Thread.Sleep(1000);

            Console.WriteLine("1--> Damage");
            Console.WriteLine("2--> Healt");
            Console.WriteLine("3--> Energy");
            Console.WriteLine("4--> Mana");
            Console.WriteLine("5--> Fire damage");
            Console.WriteLine("0--> End spending");

            int value = 5;
            
            bool running = true;
            while (running)
            {
                Console.Write("Which number: ");
                string? a = Console.ReadLine();
                int number = int.Parse(a);
                
                Console.Write("How many points: ");
                string? b = Console.ReadLine();
                int points = int.Parse(b);                    
 
                    if (points > value)
                    {
                        Console.WriteLine("You don't have enough points");
                        Thread.Sleep(800);
                    }
                    if (number == 1)         //damage
                    {                                                       
                        if (points <= value && points > 0)
                        {
                            hero.DMG = hero.DMG + (10 * points);
                            value = value - points;
                            
                            Console.WriteLine("Your new damage is " + hero.DMG);
                            Thread.Sleep(800);
                            Console.WriteLine("Now you only have " + value + " points.");
                            Thread.Sleep(800);                           
                        }
                        else if (points < 0)
                        {
                            Console.WriteLine("You can't type negative number");
                        }
                    }
                    if (number == 2 && points > 0)             //healt
                    {                                                              
                        if (points <= value)
                        {
                            hero.HP = hero.HP + (10 * points);
                            value = value - points;
                            
                            Console.WriteLine("Your new healt is " + hero.HP);
                            Thread.Sleep(800);
                            Console.WriteLine("Now you only have " + value + " points.");
                            Thread.Sleep(800);
                        }
                        else if (points < 0)
                        {
                            Console.WriteLine("You can't type negative number");
                        }
                    }
                    if (number == 3 && points > 0)            //energy
                    {
                        if (points <= value)
                        {
                            hero.ENG = hero.ENG + (10 * points);
                            value = value - points;

                            Console.WriteLine("Your new maximum energy is " + hero.ENG);
                            Thread.Sleep(800);
                            Console.WriteLine("Now you only have " + value + " points.");
                            Thread.Sleep(800);
                        }
                        else if (points < 0)
                        {
                            Console.WriteLine("You can't type negative number");
                        }
                    }
                    if (number == 4 && points > 0)             //mana
                    {
                        if (points <= value)
                        {
                            hero.Mana = hero.Mana + (10 * points);
                            value = value - points;

                            Console.WriteLine("Your new maximum mana is " + hero.Mana);
                            Thread.Sleep(800);
                            Console.WriteLine("Now you only have " + value + " points.");
                            Thread.Sleep(800);
                        }
                        else if (points < 0)
                        {
                            Console.WriteLine("You can't type negative number");
                        }
                    }
                    if (number == 5 && points > 0)             //fire damage
                    {
                        if (points <= value)
                        {
                            hero.HP = hero.HP + (10 * points);
                            value = value - points;

                            Console.WriteLine("Your new fire damage is " + hero.FireDMG);
                            Thread.Sleep(800);
                            Console.WriteLine("Now you only have " + value + " points.");
                            Thread.Sleep(800);
                        }
                        else if (points < 0)
                        {
                            Console.WriteLine("You can't type negative number");
                        }
                    }
                    if (number == 0)       //end spending points
                    {
                        Console.WriteLine("You ended spending points");
                        Thread.Sleep(1000);
                    return false;
                    }                                       
                    if (value == 0)
                    {
                        Console.WriteLine("You spended all of the points. New points can be recieved by killing enemies");
                        Thread.Sleep(1000);
                        return false;
                    }
                Console.WriteLine("Type again where and how much do you want to spend.");
                Thread.Sleep(1000);
            }
            return true;
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
            }
            Thread.Sleep(800);
            Console.WriteLine();
            Console.Write("Which type of attack do you want to perform: ");


            bool running = true;
            while (running)
            {

                string? attacktype = Console.ReadLine();
                if (attacktype == "1")
                {
                    bool Attack = hero.HeroAttack(monster); //Hero attack
                    if (Attack)
                    {
                        monster.MonsterAttack(hero);  //Monster attack

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
                            Console.WriteLine("You lost the GAME");
                            Thread.Sleep(1000);
                            Environment.Exit(0);
                        }
                        else
                            Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                            Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);
                            
                    }                    
                if (hero.ENG <= 20)
                {
                    Console.WriteLine("You don't have enought energy");
                }               
                if (attacktype == "2")
                {                   
                
                
                
                    //Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                    //Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);
                        
                    Console.WriteLine("Restoring your energy.");
                    Thread.Sleep(800);
                    hero.EnergyRegen2(monster2);
                    Console.WriteLine("Energy restored: " + hero.ENG);                 
                }
                if (attacktype == "3")
                {

                }
                if (attacktype == "4")
                {

                }
                if (attacktype == "5")
                {

                }
                if (attacktype == "6")
                {
                    {
                        Console.WriteLine("Type a number which attack do you want to perform.");
                        Console.WriteLine("1--> Melle attack");
                        Console.WriteLine("2--> Restore energy");
                        Console.WriteLine("3--> Fire attack (50% chance)");
                        Console.WriteLine("4--> Restore mana");
                        Console.WriteLine("5--> Block");
                        Console.WriteLine("6--> Info");
                    }
                    Thread.Sleep(800);
                }
            }
                return true;
        }

        /*
            Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

            
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
                        Console.WriteLine("You lost the GAME");
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
                        if (hero.HP <= 0)
                        {
                            hero.HP = 0;
                            Console.WriteLine(monster.Racetype + " HP: " + monster.HP);
                            Console.WriteLine(hero.Name + " HP: " + hero.HP + " ENG " + hero.ENG + " Mana " + hero.Mana);

                            Console.WriteLine(hero.Name + " is dead");
                            Thread.Sleep(1000);
                            Console.WriteLine("You lost the GAME");
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
            return false;
        }
        */
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
        
    
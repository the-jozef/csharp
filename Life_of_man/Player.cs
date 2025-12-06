using System;
using System.Collections.Generic;
using System.Text;

namespace Life_of_man
{
    public class Player
    {       
        public string FullName { get; set; } = "John Wick";  // Default fullname
        public int Health { get; set; } =100;    
        public int Food { get; set; } = 100;        
        public int Thirst { get; set; } = 100;
        public int Money { get; set; } = 150;
        public int Energy { get; set; } = 100;
        

        // Additional player properties and methods can be added here         
        public static bool ShowInventory1(Shop shop)
        {           
            return false;
        }


        public static bool Sleeping(Time time)
        {
            if (Time.TimeDate.Hour < 22)
            {
                Console.WriteLine("Are you sure that you want to sleep?");
                string answer = Console.ReadLine()!;
                if (answer == "yes")
                {
                    int hoursToSleep = 8;
                    Time.TimeDate = Time.TimeDate.AddHours(hoursToSleep);
                    return true;
                }
                else if (answer == "no")
                {
                    return false;
                }
            }
            else if (Time.TimeDate.Hour >= 22)
            {
                Console.WriteLine("Are you sure that you want to sleep because It is to early?");
                string answer = Console.ReadLine()!;
                if (answer == "yes")
                {
                    int hoursToSleep = 8 - (24 - Time.TimeDate.Hour);
                    Time.TimeDate = Time.TimeDate.AddHours(hoursToSleep);
                    return true;
                }
                else if (answer == "no")
                {
                    return false;
                }
            }
            return false;
        }
        public static bool Alarmclock(Time time)
        {
            Console.WriteLine("Set up the hour you want to wake up (0-23): ");
            string hourInput = Console.ReadLine()!;
            if (int.TryParse(hourInput, out int wakeUpHour) && wakeUpHour >= 0 && wakeUpHour <= 23)
            {
                int hoursToWakeUp = 




                int hoursToWakeUp = (wakeUpHour - Time.TimeDate.Hour + 24) % 24;
                Time.TimeDate = Time.TimeDate.AddHours(hoursToWakeUp);
                return true;
            }
            else
            {
                Console.WriteLine("Invalid hour input. Please enter a number between 0 and 23.");
                return false;
            }
        }
        public static bool RemoveAlarmclock()
        {
            
            return true;
        }   





    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Life_of_man
{
    public class Time
    {
        public static DateTime TimeDate { get; set; } = new DateTime(2025, 11, 29, 10, 0, 0);
        public static bool StartUITimer1()
        {
            
            System.Timers.Timer timer;
            UIManager1.DrawTimeTopRight1(TimeDate); // prvé zobrazenie

            timer = new System.Timers.Timer(1000); // každú sekundu
            timer.Elapsed += (s, e) =>
            {
                TimeDate = TimeDate.AddSeconds(10);
                UIManager1.DrawTimeTopRight1(TimeDate);
            };
            timer.AutoReset = true;
            timer.Start();           
            return true;
        }
    }
    public static class UIManager1
    {
        public static void DrawTimeTopRight1(DateTime TimeDate)
        {
            Console.ForegroundColor = ConsoleColor.White;
            // text, ktorý chceme zobraziť
            string text = TimeDate.ToString("HH:mm:ss");

            // kurzor na správnu pozíciu (pravý horný roh)
            int x = (Console.WindowWidth - text.Length)- 7;
            if (x < 0) x = 0; // pre prípad, že text je dlhší ako šírka konzoly
            Console.SetCursorPosition(x, 0);

            Console.Write($"Time: {text}");            
            Console.Write(new string(' ', 1));
            
        }        
    }
}

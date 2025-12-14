using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Text;
using System.Timers;
using System.Xml.Linq;

namespace Life_of_man
{
    public class Game
    {
        public Player Player { get; set; } = new Player();

        public void Start(Menu menu,Shop shop)
        {/*
            Console.ResetColor();
            
            Intros.GameIntro();

            Intros.Warning();            
                                 
            Others.Namesetting(Player); 
          
            Colour.SetColour(); //zapnut neskor, vylepsit
                                
            //Console.ForegroundColor = Colour.SelectedColor; //zfunkcnit uplne farbu
            */          
            Time.UIManager.StartUI(Player,Time.TimeDate, this);
                                         
            Menu.MenuControl(Player,this);

        }
        public static void ClearLine(int line)
        {
            int currentLine = Console.CursorTop;
            Console.SetCursorPosition(0, line);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, line);
        }
    }
}  

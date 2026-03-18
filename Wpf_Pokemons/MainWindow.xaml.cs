using Microsoft.VisualBasic;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics.Eventing.Reader;


namespace Wpf_Pokemons
{
    public partial class MainWindow : Window
    {
        public static int number {  get; set; }
        public Enemy enemy { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            Window_Fight window_Fight = new Window_Fight(TexBox_MyValue);
           
            Button button = (Button)sender;
            button.IsEnabled = false;
            button.Content = string.Empty;

            string myTextValue = TexBox_MyValue.Text;

            window_Fight.Show();
            */
        }
        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            Hero pikachu = new Hero(150, 150, 15, 100);          
            Enemy charizard = new Enemy("Charizard",200, 17, 100);
            Enemy charmeleon = new Enemy("Charmeleon",150, 12, 80);
            Enemy charmander = new Enemy ("Charmander",50, 8, 50);
            if(number == 1) {
                    enemy = charmander;
            }
            else if (number == 2) {
                    enemy = charmeleon;
            }
            else if (number == 3) {
                    enemy = charmander;
            }
            
            Window_Fight window_Fight = new Window_Fight(pikachu,enemy);
            window_Fight.Show();
        }

        private void Charmander_button_Click(object sender, RoutedEventArgs e)
        {
            number = 1;
        }

        private void Charmeleon_button_Click(object sender, RoutedEventArgs e)
        {
            number = 2;
        }

        private void Charizard_button_Click(object sender, RoutedEventArgs e)
        {
            number = 3;           
        }
        
        
    }
}
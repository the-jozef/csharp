using Microsoft.VisualBasic;
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

namespace Wpf_Pokemons
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Hero hero = new Hero(150,150,15,100);
            Enemy enemy = new Enemy(200,17,100);



            Window_Fight window_Fight = new Window_Fight(hero,enemy);
            window_Fight.Show();
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
    }
}
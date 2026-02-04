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

namespace _1_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Cislo { get; set; }
        public Random random { get; set; } = new Random();
        public bool Koniechry;
        public int pokusy;
        public const int Maxpokusov = 10;
        public int Poslednavzdialenost;
        


        public MainWindow()
        {
            InitializeComponent();
            Cislo = random.Next(1,101);
            Cheat.Text = Cislo.ToString();
            Koniechry = false;
            pokusy = 0;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Koniechry) return;

            pokusy++;

            Pokusy.Text = pokusy.ToString();


            string text = Cisla.Text;
            int zadanecislo = int.Parse(text);
            int Aktualnavzdialenost = Math.Abs(Cislo - zadanecislo);

            if (zadanecislo == Cislo)
            {
                Koniechry = true;
                Info.Text = "Uhadol si";

                Button_click.Visibility = Visibility.Collapsed;
                Reset.Visibility = Visibility.Collapsed;
                Cisla.Visibility = Visibility.Collapsed;
                Zadanie.Visibility = Visibility.Collapsed;

            }
            else
            {
                if (pokusy == 1)
                {
                    if (zadanecislo > Cislo)
                    {
                        Info.Text = "Nizsie";
                    }
                    if (zadanecislo < Cislo)
                    {
                        Info.Text = "Vyssie";
                    }
                    Poslednavzdialenost += Aktualnavzdialenost;
                    Dane_cislo.Text = Cisla.Text;
                    Cisla.Text = string.Empty;
                    return;
                }

                if (Aktualnavzdialenost > Poslednavzdialenost)
                {
                    Info.Text = "Chladnejsie";
                }
                if (Aktualnavzdialenost < Poslednavzdialenost)
                {
                    Info.Text = "Teplejsie";
                }
                if (Aktualnavzdialenost == Poslednavzdialenost)
                {
                    Info.Text = "Nic sa nezmenilo";
                }
            }
            Poslednavzdialenost = Aktualnavzdialenost;
            Dane_cislo.Text = Cisla.Text;
            Cisla.Text = string.Empty;
            return;
        }

        private void Cisla_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Cisla.Text = string.Empty;
            Dane_cislo.Text = string.Empty;
            Info.Text = string.Empty;
            pokusy = 0;
            Pokusy.Text = string.Empty;
            Cislo = random.Next(1, 101);                      
            Cheat.Text = Cislo.ToString();      
            return;
        }
    }
}
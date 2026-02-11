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

namespace Wpf_uloha1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool stop_en { get; set; }= false;
        public bool start_en { get; set; } = true;
        public bool check {  get; set; } = false;
        public DateTime starttime { get; set; }
        public DateTime stoptime { get; set; }
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Start_button_Click(object sender, RoutedEventArgs e)
        {
            if (start_en == false)
            {
                return;
            }
            else if (start_en == true)
            {
                starttime = DateTime.Now;

                Vysledok.Content = string.Empty;

                
                stop_en = true;
            }
        }

        private void Stop_button_Click(object sender, RoutedEventArgs e)
        {
            if(stop_en == false)
            {
              return;
            }
            else if (stop_en == true)
            {
               stoptime = DateTime.Now;

                string number = text.Text;

                text.IsEnabled = true;

                check = true;
            }
        }

        private void Check_button_Click(object sender, RoutedEventArgs e)
        {
            if (check == false)
            {
                return;
            }
            else if (check == true)
            {
                TimeSpan time = stoptime - starttime;

                Vysledok.Content = time.TotalMilliseconds.ToString();

                text.IsEnabled = false;

            }
        }
        
    }
}
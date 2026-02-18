using System.Diagnostics.Eventing.Reader;
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

namespace Wpf_uloha4
{
    
    public partial class MainWindow : Window
    {
        public string ImagePath { get; set; } = "C:\\Users\\Liskoj25\\source\\repos\\csharp\\5\\Wpf_uloha4\\minecraft_armour_sheet_by_dragonshadow3_d8ebr67-414w-2x.png";

        List<Armors> Armors_Helmets = new List<Armors>();
        List<Armors> Armorss_Body = new List<Armors>();
        List<Armors> Armorss_Pant = new List<Armors>();
        List<Armors> Armorss_Leg = new List<Armors>();

        public Armors Head { get; set; }
        public Armors Body { get; set; }
        public Armors Pants { get; set; }
        public Armors Leg { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Armors_Helmets.Add(new Armors("Plesinka", 0, eArmorType.None, eAmorPartName.Helmet, 28, 29, 100, 90));
            Armors_Helmets.Add(new Armors("Helma bronzova", 1, eArmorType.Bronze, eAmorPartName.Helmet, 28, 29, 100, 90));
            Armors_Helmets.Add(new Armors("Helma retiazkova", 2, eArmorType.Chain, eAmorPartName.Helmet, 177, 29, 100, 90));
            Armors_Helmets.Add(new Armors("Helma zelezna", 5, eArmorType.Iron, eAmorPartName.Helmet, 338, 29, 100, 90));
            Armors_Helmets.Add(new Armors("Helma zlata", 10, eArmorType.Gold, eAmorPartName.Helmet, 505, 29, 100, 90));
            Armors_Helmets.Add(new Armors("Helma diamantova", 20, eArmorType.Diamant, eAmorPartName.Helmet, 659, 29, 100, 90));
    
            ComboBox_helmet.ItemsSource = Armors_Helmets;

            Armorss_Body.Add(new Armors("Hola hrud", 0, eArmorType.None, eAmorPartName.Body, 0, 0, 0, 0));
            Armorss_Body.Add(new Armors("Body bronzove", 5, eArmorType.Bronze, eAmorPartName.Body, 7, 136, 139, 130));
            Armorss_Body.Add(new Armors("Body retiazkove", 10, eArmorType.Chain, eAmorPartName.Body, 159, 136, 139, 130));
            Armorss_Body.Add(new Armors("Body zelezne", 15, eArmorType.Iron, eAmorPartName.Body, 321, 136, 139, 130));
            Armorss_Body.Add(new Armors("Body zlate", 30, eArmorType.Gold, eAmorPartName.Body, 486, 136, 139, 130));
            Armorss_Body.Add(new Armors("Body diamantove", 50, eArmorType.Diamant, eAmorPartName.Body, 639, 136, 139, 130));
            
            ComboBox_BodyPicker.ItemsSource = Armorss_Body;


            Armorss_Pant.Add(new Armors("Trenky", 0, eArmorType.None, eAmorPartName.Pant, 0, 0, 0, 0));
            Armorss_Pant.Add(new Armors("Nohavice bronzove", 2, eArmorType.Bronze, eAmorPartName.Pant, 26, 279, 100, 131));
            Armorss_Pant.Add(new Armors("Nohavice retiazkove", 4, eArmorType.Chain, eAmorPartName.Pant, 179, 279, 100, 131));
            Armorss_Pant.Add(new Armors("Nohavice zelezne", 8, eArmorType.Iron, eAmorPartName.Pant, 339, 279, 100, 131));
            Armorss_Pant.Add(new Armors("Nohavice zlate", 15, eArmorType.Gold, eAmorPartName.Pant, 506, 279, 100, 131));
            Armorss_Pant.Add(new Armors("Nohavice diamantove", 22, eArmorType.Diamant, eAmorPartName.Pant, 657, 279, 100, 131));
            
            ComboBox_PantPicker.ItemsSource = Armorss_Pant;

            Armorss_Leg.Add(new Armors("Sandale", 0, eArmorType.None, eAmorPartName.Leg, 0, 0, 0, 0));
            Armorss_Leg.Add(new Armors("Topanky bronzove", 2, eArmorType.Bronze, eAmorPartName.Leg, 2, 425, 140, 100));
            Armorss_Leg.Add(new Armors("Topanky retiazkove", 4, eArmorType.Chain, eAmorPartName.Leg, 159, 425, 140, 100));
            Armorss_Leg.Add(new Armors("Topanky zelezne", 8, eArmorType.Iron, eAmorPartName.Leg, 319, 425, 140, 100));
            Armorss_Leg.Add(new Armors("Topanky zlate", 15, eArmorType.Gold, eAmorPartName.Leg, 484, 425, 140, 100));
            Armorss_Leg.Add(new Armors("Topanky diamantove", 22, eArmorType.Diamant, eAmorPartName.Leg, 636, 425, 140, 100));
           
            ComboBox_LegPicker.ItemsSource = Armorss_Leg;
        }
        public void UpdateLabels()
        {
            var playerSet = new List<Armors>();

            if (Head != null)
                playerSet.Add(Head);
            if (Body != null)
                playerSet.Add(Body);
            if (Pants != null)
                playerSet.Add(Pants);
            if (Leg != null)
                playerSet.Add(Leg);

            int total = playerSet.Sum(item => item.ArmorPower);
            test.Content = total;



            //PRepocitavanie a zapousivabnie do lablu
        }
        private void ComboBox_helmet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //Armors iteminfo = ComboBox_helmet.SelectedItem as Armors;
            Armors Armors = (Armors)ComboBox_helmet.SelectedItem;
            if (Armors.ArmorType != eArmorType.None)
            {
                ActualArmor.Content = Armors.ArmorPower;

                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();

                var cropped = new CroppedBitmap(bitmap, new Int32Rect(Armors.XLeft, Armors.YTop, Armors.Width, Armors.Height));
                cropped.Freeze();

                Image_HelmetPlaceHolder.Source = cropped;
                Image_HelmetPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                Image_HelmetPlaceHolder.Visibility= Visibility.Collapsed;
            }
            Head = Armors;
            UpdateLabels();
        }
        private void ComboBox_BodyPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Armors Armors = (Armors)ComboBox_BodyPicker.SelectedItem;
            if (Armors.ArmorType != eArmorType.None)
            {
                ActualArmor.Content = Armors.ArmorPower;

                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();

                var cropped = new CroppedBitmap(bitmap, new Int32Rect(Armors.XLeft, Armors.YTop, Armors.Width, Armors.Height));
                cropped.Freeze();

                Image_BodyPlaceHolder.Source = cropped;
                Image_BodyPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                Image_BodyPlaceHolder.Visibility= Visibility.Collapsed;
            }
            Body = Armors;
            UpdateLabels();
        }

        private void ComboBox_PantPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Armors Armors = (Armors)ComboBox_PantPicker.SelectedItem;
            if (Armors.ArmorType != eArmorType.None)
            {
                ActualArmor.Content = Armors.ArmorPower;

                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();

                var cropped = new CroppedBitmap(bitmap, new Int32Rect(Armors.XLeft, Armors.YTop, Armors.Width, Armors.Height));
                cropped.Freeze();

                Image_PantsPlaceHolder.Source = cropped;
                Image_PantsPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                Image_PantsPlaceHolder.Visibility= Visibility.Collapsed;    
            }
            Body = Armors;
            UpdateLabels();
        }

        private void ComboBox_LegPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Armors Armors = (Armors)ComboBox_LegPicker.SelectedItem;
            if (Armors.ArmorType != eArmorType.None)
            {
                ActualArmor.Content = Armors.ArmorPower;

                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();

                var cropped = new CroppedBitmap(bitmap, new Int32Rect(Armors.XLeft, Armors.YTop, Armors.Width, Armors.Height));
                cropped.Freeze();

                Image_LegPlaceHolder.Source = cropped;
                Image_LegPlaceHolder.Visibility = Visibility.Visible;
            }
            else {
                Image_LegPlaceHolder.Visibility = Visibility.Collapsed;       
            }
            Leg = Armors;
            UpdateLabels();
        }
    }
}
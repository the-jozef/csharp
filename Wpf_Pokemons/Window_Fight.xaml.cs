using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Wpf_Pokemons
{
    public partial class Window_Fight : Window
    {
        public Hero ActualHero { get; set; }
        public Enemy ActualEnemy { get; set; }

        public Window_Fight(Hero hero,Enemy enemy)
        {
            InitializeComponent();

            ActualHero = hero;
            ActualEnemy = enemy;


            ProgressBar_Hero.Value = hero.Health;
            ProgressBar_Hero.Maximum = hero.MaxHealth;


            ProgressBar_Monster.Value = enemy.MaxHealth;
            ProgressBar_Monster.Maximum = enemy.MaxHealth;

            Energy_bar.Value = hero.Energy;
        }
        private void ProgressBar()
        {
            ProgressBar_Monster.Value = ActualEnemy.MaxHealth;
            ProgressBar_Hero.Value = ActualHero.Health;
            Energy_bar.Value = ActualHero.Energy;
        }
        private void AttackToEnemy(int DMG_scale )
        {
            if (ActualHero.Energy > 10 * DMG_scale)
            {
                ActualEnemy.MaxHealth -= ActualHero.DMG * DMG_scale;
                ActualHero.Health -= ActualEnemy.DMG;
                ActualHero.Energy -= 10 * DMG_scale;
            }
            else if (ActualHero.Energy < 10 * DMG_scale) ActualHero.Energy += 30;
        }
        private void Button_LightAttack_Click(object sender, RoutedEventArgs e)
        {
            AttackToEnemy(1);
            CheckStatus();
            ProgressBar();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AttackToEnemy(2);
            CheckStatus();
            ProgressBar();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AttackToEnemy(5);
            CheckStatus();
            ProgressBar();
        }
        private void CheckStatus()
        {
            if(ActualHero.Health <= 0)
            {
                Label_Death.Content = "Loser";
                Button_LightAttack.IsEnabled = false;
                Button_MediumAttack.IsEnabled = false;
                Button_CriticalAttack.IsEnabled = false;
                Hero_Image.Source = new BitmapImage(new Uri(@"/Images/Sad.png", UriKind.Relative));
                
            }
            else if (ActualEnemy.MaxHealth <= 0)
            {
                Label_Death.Content = "Winner";
                Hero_Image.Source = new BitmapImage(new Uri(@"/Images/Victory.png", UriKind.Relative));
            }
        }
    }
}

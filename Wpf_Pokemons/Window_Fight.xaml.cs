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
        public Hero hero { get; set; } 
        public Enemy ActualEnemy { get; set; }
        public Random Random { get; set; } = new Random();

        public Window_Fight(Hero pikachu,Enemy enemy)
        {
            InitializeComponent();     
            hero = pikachu;
            ActualEnemy = enemy;

            Image();

            ProgressBar_Hero.Value = hero.Health;
            ProgressBar_Hero.Maximum = hero.MaxHealth;


            ProgressBar_Monster.Value = ActualEnemy.MaxHealth;
            ProgressBar_Monster.Maximum = ActualEnemy.MaxHealth;

            Energy_bar.Value = hero.Energy;
        }
        private void Image()
        {
            if(ActualEnemy.Name == "Charizard")
            {
                EnemyPic.Source = new BitmapImage(new Uri("Images/Charizard.png", UriKind.Relative));
            }
            else if(ActualEnemy.Name == "Charmeleon")
            {
                EnemyPic.Source = new BitmapImage(new Uri("Images/charmeleon.png", UriKind.Relative));
            }
            else if (ActualEnemy.Name == "Charmander")
            {
                EnemyPic.Source = new BitmapImage(new Uri("Images/charmander.png", UriKind.Relative));
            }
        }
        private void ProgressBar()
        { if (hero.Health > 0)
            {

                if (hero.Health < 100 && hero.Health > 50)
                {
                    ProgressBar_Hero.Foreground = new SolidColorBrush(Colors.Orange);
                }
                else if (hero.Health < 50)
                {
                    ProgressBar_Hero.Foreground = new SolidColorBrush(Colors.Red);
                }
                if (ActualEnemy.MaxHealth < 100 && ActualEnemy.MaxHealth > 50)
                {
                    ProgressBar_Hero.Foreground = new SolidColorBrush(Colors.Orange);
                }
                else if (ActualEnemy.MaxHealth < 50)
                {
                    ProgressBar_Hero.Foreground = new SolidColorBrush(Colors.Red);
                }
                Hero_Health.Content = hero.Health + "/250";
                ProgressBar_Monster.Value = ActualEnemy.MaxHealth;
                ProgressBar_Hero.Value = hero.Health;
                Energy_bar.Value = hero.Energy;
            }
            else
            { if (hero.Health < 0)
                {
                    hero.Health = 0;
                    Hero_Health.Content = hero.Health + "/250";
                    ProgressBar_Monster.Value = ActualEnemy.MaxHealth;
                    ProgressBar_Hero.Value = hero.Health;
                    Energy_bar.Value = hero.Energy;
                    CheckStatus();
                }
            }
        }
        private void AttackToActualEnemy(int DMG_scale )
        {if (Random.Next(0,101) > 35)
            {
                if (hero.Energy > 10 * DMG_scale)
                {
                    ActualEnemy.MaxHealth -= hero.DMG * DMG_scale;
                    hero.Health -= ActualEnemy.DMG;
                    hero.Energy -= 10 * DMG_scale;
                }
                else if (hero.Energy < 10 * DMG_scale)
                {
                    hero.Health -= ActualEnemy.DMG;
                    hero.Energy += 30;
                }
            }
            else
            {
                ActualEnemy.MaxHealth -= Random.Next(0,6);
                hero.Health -= ActualEnemy.DMG;
            }
        }
        private void Button_LightAttack_Click(object sender, RoutedEventArgs e)
        {
            AttackToActualEnemy(1);
            CheckStatus();
            ProgressBar();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AttackToActualEnemy(2);
            CheckStatus();
            ProgressBar();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AttackToActualEnemy(5);
            CheckStatus();
            ProgressBar();
        }
        private void CheckStatus()
        {
            if(hero.Health <= 0)
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

        private void Button_HealAttack_Click(object sender, RoutedEventArgs e)
        {
            if (hero.Health <= 100 - 15 && hero.Energy > 25)
            {
                hero.Energy -=  25;
                hero.Health += 22;
                hero.Health -= ActualEnemy.DMG;
                ProgressBar();
            }
            else
            {

            }
        }

        private void Button_Restart_Click(object sender, RoutedEventArgs e)
        {
            hero.Energy = 100;
            hero.Health = 150;
            ActualEnemy.Energy = 100;
            ActualEnemy.MaxHealth = 200;

            Button_LightAttack.IsEnabled = true;
            Button_MediumAttack.IsEnabled = true;
            Button_CriticalAttack.IsEnabled = true;
                      

            ProgressBar();


        }

        private void Button_EnergyReboot_Click(object sender, RoutedEventArgs e)
        {
            hero.Energy += 25;
            hero.Health -= ActualEnemy.DMG;

            ProgressBar();
        }
    }
}

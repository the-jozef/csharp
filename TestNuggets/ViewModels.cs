using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
    using CommunityToolkit.Mvvm.Input;
    using System.Windows;
namespace TestNuggets.Viewmodels
{



    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _userName = "";

        // NOVÉ: Počet znakov v mene (bude sa automaticky aktualizovať)
        [ObservableProperty]
        private int _nameLength = 0;
        
        [RelayCommand]
        private void Greet()
        {
            if (string.IsNullOrWhiteSpace(UserName))
            {
                MessageBox.Show("Prosím zadaj svoje meno!", "Chyba");
                return;
            }

            MessageBox.Show($"Ahoj, {UserName}!", "Pozdrav");
        }

        // NOVÝ command: Vymaže meno
        [RelayCommand]
        private void Clear()
        {
            UserName = "";
            NameLength = 0;
        }
        [RelayCommand]
        private void UpperCase()
        {
            UserName = UserName.ToUpper();
        }

        // Špeciálna metóda, ktorá sa zavolá automaticky keď sa zmení UserName
        partial void OnUserNameChanged(string value)
        {
            NameLength = value?.Length ?? 0;
        }
    }
}


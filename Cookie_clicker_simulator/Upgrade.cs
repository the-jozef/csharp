using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_clicker_simulator
{
    public abstract class Upgrade
    {
        public virtual string UpgradeName { get; set; }   //nazov upgradu
        public override int CookiesPriceToBuy { get; set; }  //cena za Cookie upgrade
        public virtual int Multiplier { get; set; }      //Nasobit; udrzuje info o tom 
        public abstract void Apply(Player player);
        public abstract void CalculateCookiesForUpgrade(Player player);
        public abstract void GetUpgradeInfo();
    }
}

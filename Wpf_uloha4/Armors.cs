using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_uloha4
{
    public class Armors
    {
        public string Displayname { get; set; }
        public int ArmorPower { get; set; }
        public eArmorType ArmorType { get; set; }
        public eAmorPartName ArmorPartName { get; set; }

        public int XLeft { get; set; }
        public int YTop { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Armors(string displayname, int armorPower, eArmorType armorType, eAmorPartName armorPartName, int xLeft, int yTop, int width, int height)
        {
            Displayname = displayname;
            ArmorPower = armorPower;
            ArmorType = armorType;
            ArmorPartName = armorPartName;
            XLeft = xLeft;
            YTop = yTop;
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return Displayname;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_simulator
{
    public class Plant
    {
        public string PlantType { get; set; }
        public int TimeForHarvest { get; set; }
        public int TimeInGround { get; set; }
        public int Price { get; set;  }


        public Plant(string plantID, int timetoHarvest, int price)
        {
            PlantType = plantID;
            TimeForHarvest = timetoHarvest;
            //TimeInGround = timeinground;
            Price = price;
        }
        public override string ToString()
        {
            return $"{PlantType} {TimeInGround}/{TimeForHarvest} Days {Price}$";
        }
    }
}

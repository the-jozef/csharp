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
        public int PlantPrice { get; set;  }
        public int SalePrice { get; set; }


        public Plant(string plantID, int timetoHarvest,int saleprice, int plantprice)
        {
            PlantType = plantID;
            TimeForHarvest = timetoHarvest;
            SalePrice = saleprice;
            PlantPrice = plantprice;
        }
        public override string ToString()
        {
            return $"{PlantType} {TimeInGround}/{TimeForHarvest} Days  Sale: {SalePrice}$   Price: {PlantPrice}$";
        }
    }
}

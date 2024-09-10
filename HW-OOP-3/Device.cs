using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_3
{
    internal class Device
    {
        private double maxVolumeDough;
        public double MaxVolumeDough
        {
            get { return maxVolumeDough; }
            set { if (maxVolumeDough >0 && maxVolumeDough <= 500) maxVolumeDough = value; }
        }
        private double maxVolumeFilling;
        public double MaxVolumeFilling
        {
            get { return maxVolumeFilling; }
            set { if (maxVolumeFilling > 0 && maxVolumeFilling <=100) maxVolumeFilling = value; }
        }
        private double consumptiontDough;
        public double ConsumptionDough
        {
            get { return consumptiontDough; }
            set { if (consumptiontDough > 0 && consumptiontDough <= 50) consumptiontDough = value; }
        }
        private double consumptionFilling;
        private double consumptiontFilling
        {
            get { return consumptionFilling; }
            set { if (consumptionFilling > 0 && consumptionFilling <= 5) consumptionFilling = value; }
        }






           
        private double addDough;
        public double AddDough
        { 
            get { return addDough; } 
            set { addDough = value; } 
        }

    }
}

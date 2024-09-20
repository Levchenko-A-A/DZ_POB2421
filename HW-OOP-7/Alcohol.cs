using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_7
{
    internal class Alcohol: Liquid
    {
        private double fortress;
        public double Fortress 
        { 
            get { return fortress; } 
            set { if (value >= 1.5 && value <= 96) fortress = value;
                  else throw new Exception("Данный напиток не является алкогольным.");
            }
        }
    }
}

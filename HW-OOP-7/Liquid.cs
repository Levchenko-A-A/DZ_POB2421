using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_7
{
    internal class Liquid
    {
        private string? name;
        public string? Name {get; set; }
        private double density;
        public double Density 
        {
            get { return density; }
            set { if (value >= 0.0708 && value <= 13.6) density = value;
                else throw new Exception("Введенный диапазон не входит в границы от 0.0708 до 13.6");
            } 
        }
    }
}

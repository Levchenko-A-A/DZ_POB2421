using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_7
{
    internal class Rectangle: Pair
    {
        public Rectangle(double First, double Second) : base(First, Second)
        {
        }
        public double Perimeter() => 2*First + 2*Second;
        public double Square() => First * Second;
        public new double Mul() => First * Second;

    }
}

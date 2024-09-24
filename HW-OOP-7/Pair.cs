using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_7
{
    internal class Pair
    {
        private double first;
        public double First
        {
            get {return first; }
            set {if(value>=0) first=value; }
        }
        private double second;
        public double Second 
        {
            get {return second; }
            set { if (value >= 0) second = value; }
        }
        public Pair(double first, double second)
        {
            First = first;
            Second = second;
        }
        public double Mul() => First * Second;
        public void ChangeFirst(double newFirst)
        {
            First = newFirst;
        }
        public void ChangeSecond(double newSecond)
        {
            Second = newSecond;
        }
    }
}

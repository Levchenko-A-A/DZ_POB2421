using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork28_1
{
    internal class NumberRandom
    {
        public int RanNumber(int n, int m)
        {
            Random random = new Random();
            return random.Next(n, m);
        }
    }
}

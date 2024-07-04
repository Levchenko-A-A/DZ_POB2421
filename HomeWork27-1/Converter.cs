using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork27_1
{
    internal class Converter
    {
        public static decimal ToDollars(decimal currency)
        {
            return currency / 87.95m;
        }
        public static decimal ToEuros(decimal currency)
        {
            return currency / 94.58m;
        }
        public static decimal ToZlotys(decimal currency)
        {
            return currency / 21.99m;
        }
        public static decimal ToYuan(decimal currency)
        {
            return currency / 11.89m;
        }
        public static decimal ToRupes(decimal currency)
        {
            return currency / 1.05m;
        }
    }
}

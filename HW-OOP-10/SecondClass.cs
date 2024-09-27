using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_10
{
    internal class SecondClass: NumberClass
    {
        public int SecondNumber { get; set; }
        public int this[int index, int index2]
        {
            get
            {
                int numberToUse = (index == 0) ? FirstNumber : SecondNumber;
                string numberStr = numberToUse.ToString();
                if (index2 < 0 || index2 >= numberStr.Length)
                    throw new IndexOutOfRangeException("Индекс выходит за пределы разряда");
                return int.Parse(numberStr[numberStr.Length - 1 - index2].ToString());
            }
        }
    }
}

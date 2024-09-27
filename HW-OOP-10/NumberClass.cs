using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_10
{
    internal class NumberClass
    {
        public int FirstNumber { get; set; }
        public virtual int this[int index]
        {
            get
            {
                string str = FirstNumber.ToString();
                if (index < 0 || index >= str.Length)
                    throw new IndexOutOfRangeException("Индекс выходит за пределы числа");
                return int.Parse(str[str.Length - 1 - index].ToString());
            }
        }
    }
}

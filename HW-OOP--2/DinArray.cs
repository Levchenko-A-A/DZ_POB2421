using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW_OOP__2
{
    internal class DinArray
    {
        public List<int> list { get; set; } = new();

        public DinArray()
        {
            Random random = new Random();
            for (int i = 0; i < random.Next(10, 100); i++)
                list.Add(random.Next(10, 100));
        }
        public void Print()
        {
            foreach (int i in list) Console.Write(i + " ");
            Console.WriteLine();
        }
        public void Rearrange()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Random random1 = new Random();
                Random random2 = new Random();
                int one = random1.Next(0, list.Count);
                int two = random2.Next(0, list.Count);
                int tmp = list[one];
                list[one] = list[two];
                list[two] = tmp;
            }
        }
        public void DinCount()
        {
            Console.Write("Количество различных элементов в массиве:" + list.Distinct().Count());
        }
        public int this[int i]
        {
            get => list[i];
            set => list[i] = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_6
{
    internal class StaticString
    {
        public static void FillString(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str[i] += (i+1+" ").ToString();
                Random random = new Random();
                  for (int j = 0; j < 10; j++)
                     str[i] += random.Next(0, 10);
            }
        }
        public static void PrintStringMas(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
                Console.WriteLine(str[i]);
            Console.WriteLine();
        }
        public static void ChangeStringMas(string[] mas)
        {
            for (int i = 0; i < mas.Length / 2; i++)
                (mas[i], mas[mas.Length - i - 1]) = (mas[mas.Length - i - 1], mas[i]);
        }
    }
}

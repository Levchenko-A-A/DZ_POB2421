using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_6
{
    internal class StaticMas
    {
        public static void FillMas(double[] mas)
        {
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
                mas[i] = random.NextDouble()*100;
        }
        public static void PrintMas(double[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                Console.Write($"{mas[i]:F2} ");
            Console.WriteLine();
        }
        public static double GetAvgNumber(double[] mas)
        {
            double sum = 0;
            for (int i = 0; i < mas.Length;i++)
                sum += mas[i];
            return sum/mas.Length;
        }
    }
}

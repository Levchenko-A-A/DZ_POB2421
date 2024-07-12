using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork27_3
{
    internal class Numbers
    {
        public void GeneretAverage(double[] mas)
        {
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++) 
            {
                mas[i]=random.NextDouble()*100;
                Console.Write($"{mas[i]:F2} ");
            }
        }
        public double CalculateAverage(double[] mas)
        {
            double result=0;
            for (int i = 0; i < mas.Length; i++)
            {
                result += mas[i];
            }
            return result/mas.Length;
        }
        public bool IsPrime (int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        public bool IsEven (int number) 
        {
            if((number % 2) == 0) return true;
            else return false;
        }
        public bool IsOdd(int number)
        {
            if ((number % 2) == 0) return false;
            else return true;
        }
    }
}

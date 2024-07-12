using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork27_4
{
    internal class Numbers
    {
        public void GeneretAverage(double[] mas)
        {
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.NextDouble() * 100;
                Console.Write($"{mas[i]:F2} ");
            }
        }
        public double CalculateAverage(double[] mas)
        {
            double result = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                result += mas[i];
            }
            return result / mas.Length;
        }
        public bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        public bool IsEven(int number)
        {
            if ((number % 2) == 0) return true;
            else return false;
        }
        public bool IsOdd(int number)
        {
            if ((number % 2) == 0) return false;
            else return true;
        }
        public int CalculateFactorial(int number)
        {
            return number == 0 ? 1 : CalculateFactorial(number - 1) * number;
        }
        public string ConvertToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }
        public string ConvertToHex(int number)
        {
            return Convert.ToString(number, 16).ToUpper();
        }
        public double CalculatePower (int number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}

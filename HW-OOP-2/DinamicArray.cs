using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_2
{
    internal class DinamicArray
    {
        private int[] number = new int[2];
        private int lenght=0;

        public DinamicArray(int _lenght)
        {
            Array.Resize(ref number, _lenght);
        }
        public void masRandom()
        {
            Random random = new Random();
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(0, 100);
            }
        }
        public void masPrint()
        {
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i]+" ");
            }
        }
        public void masRandomChange()
        {
            for(int i = 0;i<number.Length;i++)
            {
                Random random1=new Random();
                Random random2 = new Random();
                int one = random1.Next(0,number.Length);
                int two = random2.Next(0,number.Length);
                int tmp = number[one];
                number[one]=number[two];
                number[two]=tmp;
            }
        }
        public void masCount()
        {
            Console.Write("Количество различных элементов в массиве:"+ number.Distinct().Count());
        }
        public int masLength()
        {
            return number.Length;
        }

        ~DinamicArray(){ }
    }
}

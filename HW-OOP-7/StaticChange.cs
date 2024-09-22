using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_7
{
    class StaticChange
    {
        public static void Print(List<Liquid> liquids)
        {
            foreach (Liquid liq in liquids)
            {
                if (liq is Alcohol)
                    Console.WriteLine($"{liq.Name,-18}{liq.Density,-6}{((Alcohol)liq).Fortress,-8}");
                else
                    Console.WriteLine($"{liq.Name,-18}{liq.Density,-6}");
            }
        }
        public static void ChangeName(List<Liquid> listLiq, string nameFind, string nameChange)
        {
            Liquid tmp1 = new Liquid();
            foreach (Liquid liquid in listLiq)
            {
                tmp1 = liquid;
                if(tmp1 != null&& tmp1.Name==nameFind) 
                    liquid.Name = nameChange;
            }
        }
    }
}

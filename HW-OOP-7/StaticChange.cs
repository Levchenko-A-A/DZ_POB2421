using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_7
{
    class StaticChange
    {
        public static void ChangeName(List<Liquid> listLiq, string nameFind, string nameChange)
        {
            Alcohol tmp1 = new Alcohol();
            Liquid tmp2 = new Liquid();
            for (int i=0; i<listLiq.Count; i++)
            {
                if (listLiq is Alcohol)
                {
                    tmp1 = listLiq[i];
                }
                else
                {
                    tmp2 = listLiq[i];
                    if (tmp2.Name == nameFind)
                        tmp2.Name = nameChange;
                    listLiq[i] = tmp2;
                }
            }
        }
    }
}

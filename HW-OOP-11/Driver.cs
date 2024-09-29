using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_11
{
    internal class Driver
    {
        public string? Name { get; set; }

        public void MakeRepairRequest()
        {
            Console.WriteLine($"Водитель {Name} подал заявку на ремонт");
        }

        public void MakeTripReport()
        {
            Console.WriteLine($"Водитель {Name} составил отчет о поездке");
        }
    }
}

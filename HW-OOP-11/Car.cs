using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_11
{
    internal class Car
    {
        public string? Model { get; set; }

        public void MakeRepair()
        {
            Console.WriteLine($"Автомобиль {Model} находится на ремонте");
        }

        public void CheckCondition()
        {
            Console.WriteLine($"Состояние автомобиля {Model} проверено");
        }
    }
}

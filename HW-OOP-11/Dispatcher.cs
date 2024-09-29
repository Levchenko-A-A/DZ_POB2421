using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_11
{
    internal class Dispatcher
    {
        public void AssignTrip(Driver driver, Car car)
        {
            Console.WriteLine($"Поездка, назначенная водителю {driver.Name} на машине {car.Model}");
        }

        public void SuspendDriver(Driver driver)
        {
            Console.WriteLine($"Водитель {driver.Name} отстранен");
        }

    }
}

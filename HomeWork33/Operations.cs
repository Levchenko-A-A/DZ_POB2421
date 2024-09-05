using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork33
{
    internal class Operations
    {
        public List<string>? ListString { get; set; } = new();

        public Operations()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите " + (i + 1) + " строку:");
                ListString.Add(Console.ReadLine()!);
            }
        }
    }
}

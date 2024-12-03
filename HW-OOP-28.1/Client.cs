using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_28._1
{
    internal class Client
    {
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? Email { get; set; }

        public Client(string? name, string? surName, string? email)
        {
            Name = name;
            SurName = surName;
            Email = email;
        }
    }
}

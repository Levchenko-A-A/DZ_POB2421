using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_29._1
{
    internal class Person
    {
        [Name("UserName")]
        public string? Name { get; set; }
        [Name("UserAge")]
        public int Age { get; set; }  
    }
}

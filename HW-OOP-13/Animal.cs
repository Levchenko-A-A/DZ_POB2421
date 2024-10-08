using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_OOP_13
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public Animal(int id, string? name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public abstract double AmountOfFood();
    }
}

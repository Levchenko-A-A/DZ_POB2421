using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_13._1
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public abstract double Weight { get; set; }
        public int Age { get; set; }
        public abstract string? TypeOfFood { get; }
        public abstract double NormOnePer { get; set; }
        public abstract double FoodQuantity { get; }

        public Animal(int id, string? name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public abstract double AmountOfFood();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_13
{
    internal class Predator : Animal
    {
        double weight;
        public double Weight
        {
            get => weight;
            set { if (value > 0) weight = value; }
        }
        public string? TypeOfFood => "Хищное";
        double normOnePer;
        public double NormOnePer
        {
            get => normOnePer;
            set { if (value > 0) normOnePer = value; }
        }
        public double FoodQuantity
        {
            get { return AmountOfFood(); }
        }
        public Predator(int id, string? name, int age, double weight, double normOnePer) : base(id, name, age)
        {
            Weight = weight;
            NormOnePer = normOnePer;
        }
        public override double AmountOfFood()
        {
            return Math.Round(weight * normOnePer, 3);
        }
        public override string? ToString()
        {
            return $"{Id,4} {Name,-8}{Age,-9}{Weight,-7}{NormOnePer,-11}{TypeOfFood,-25}{AmountOfFood()}";
        }
    }
}

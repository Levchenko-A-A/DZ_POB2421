﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_13._1
{
    internal class Herbivore : Animal
    {
        double weight;
        public override double Weight
        {
            get => weight;
            set { if (value > 0) weight = value; }
        }
        public override string? TypeOfFood => "Всеядное";
        double normOnePer;
        public override double NormOnePer
        {
            get => normOnePer;
            set { if (value > 0) normOnePer = value; }
        }
        public override double FoodQuantity
        {
            get { return AmountOfFood(); }
        }
        public Herbivore(int id, string? name, double weight, int age, double normOnePer) : base(id, name, age)
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

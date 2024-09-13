using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_5
{
    internal class Device
    {
        private double maxVolumeDough;
        public double MaxVolumeDough
        {
            get { return maxVolumeDough; }
            set { if (value > 0 && value <= 500) maxVolumeDough = value; }
        }
        private double maxVolumeFilling;
        public double MaxVolumeFilling
        {
            get { return maxVolumeFilling; }
            set { if (value > 0 && value <= 100) maxVolumeFilling = value; }
        }
        private double consumptionDough;
        public double ConsumptionDough
        {
            get { return consumptionDough; }
            set { if (value > 0 && value <= 50) consumptionDough = value; }
        }
        private double consumptionFilling;
        public double ConsumptionFilling
        {
            get { return consumptionFilling; }
            set { if (value > 0 && value <= 5) consumptionFilling = value; }
        }
        private double currentDough;
        public double CurrentDough
        {
            get { return currentDough; }
            set { currentDough = value; }
        }
        private double currentFilling;
        public double CurrentFilling
        {
            get { return currentFilling; }
            set { currentFilling = value; }
        }
        public void AddDough(double vol)
        {
            if (vol + currentDough <= maxVolumeDough)
                currentDough += vol;
            else currentDough = maxVolumeDough;
        }
        public void AddFilling(double vol)
        {
            if (vol + currentFilling <= maxVolumeFilling)
                currentFilling += vol;
            else currentFilling = maxVolumeFilling;
        }
        public void CountDough(int number)
        {
            if (number * consumptionDough <= currentDough)
                currentDough -= number * consumptionDough;
            else Console.WriteLine("Для выпуска данного количества недостаточно теста");
        }
        public void CountFilling(int number)
        {
            if (number * consumptionFilling <= currentFilling && number * consumptionDough <= currentDough)
            {
                currentDough -= number * consumptionDough;
                currentFilling -= number * consumptionFilling;
            }
            else Console.WriteLine("Для выпуска данного количества недостаточно теста и начинки");
        }
        public void AllCountDough()
        {
            Console.WriteLine($"Кол-во пончиков, которое можно выпустить из оставшегося теста: {currentDough / consumptionDough:F0}");
        }
        public void AllCountFilling()
        {
            Console.WriteLine($"Кол-во пончиков, которое можно выпустить из оставшегося теста: {currentFilling / consumptionFilling:F0}");
        }
        public void Print()
        {
            Console.WriteLine($"Текуший объем теста для пончиков: {currentDough}\nТекущий объем начинки для приготовления пончиков: {currentFilling}\n");
        }
    }
}

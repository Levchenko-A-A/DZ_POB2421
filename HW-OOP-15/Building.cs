using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_15
{
    internal class Building
    {
        public delegate double Сalc(Building bg);
        public static Сalc operation = CalculateVolume;

        public string? BuildingName { get; set; }
        public double Height { get; set; }
        public int Floors { get; set; }
        public double TotalArea { get; set; }
        public string? Location { get; set; }

        public Building(string? buildingName, double height, int floors, double totalArea, string? location)
        {
            BuildingName = buildingName;
            Height = height;
            Floors = floors;
            TotalArea = totalArea;
            Location = location;
        }
        public static double CalculateVolume(Building bg)
        {
            return bg.Height*bg.TotalArea;
        }

        public static void Volume(List<Building> bd)
        {
            foreach (Building i in bd)
            {
                Console.WriteLine($"Название: {i.BuildingName}");
                Console.WriteLine($"Высота: {i.Height} м");
                Console.WriteLine($"Количество этажей: {i.Floors}");
                Console.WriteLine($"Общая площадь: {i.TotalArea} кв.м.");
                Console.WriteLine($"Местоположение: {i.Location}");
                Console.WriteLine($"Объём: {operation(i)} куб.м.");
                Console.WriteLine();
            }
        }
    }
}

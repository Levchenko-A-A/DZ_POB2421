using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW_OOP_13._1
{
    internal class ListChanges
    {
        public static void PrintList(List<Animal> list)
        {
            if (list != null && list.Any())
            {
                Console.WriteLine("\n ID  Имя     Возраст  Вес    Норма/1кг  Тип питания              Суточная норма в кг\\n");
                foreach (Animal item in list)
                    Console.WriteLine(item);
            }
            else Console.WriteLine("Список пустой");
        }
        public static void PrintCountName(List<Animal> list, int count)
        {
            Console.WriteLine();
            foreach (Animal item in list.Take(count))
                Console.WriteLine(item.Name);
        }
        public static void PrintLastId(List<Animal> list, int count)
        {
            Console.WriteLine();
            foreach (Animal item in list.TakeLast(count))
                Console.WriteLine(item.Id);
        }
        public static void ListSortFoodQuantity(List<Animal> list)
        {
            if (list != null && list.Any())
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var key = list[i];
                    int j = i - 1;
                    while (j >= 0 && list[j].AmountOfFood() < key.AmountOfFood())
                    {
                        list[j + 1] = list[j];
                        j--;
                    }
                    list[j + 1] = key;
                }
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j + 1].AmountOfFood() == list[j].AmountOfFood())
                    {
                        if (list[j + 1].Name.CompareTo(list[j].Name) < 0)
                        {
                            var temp = list[j + 1];
                            list[j + 1] = list[j];
                            list[j] = temp;
                        }
                    }
                }
            }
            else Console.WriteLine("Список пустой");
        }
        public static void SaveFile(List<Animal> list, string name)
        {
            using (StreamWriter writer = new StreamWriter(name, false))
            {
                foreach (var animal in list)
                {
                    writer.WriteLine(animal);
                }
            }
        }
        public static void ReadFile(List<Animal> list, string name)
        {
            try
            {
                using (StreamReader reader = new StreamReader(name))
                {
                    string line;
                    while ((line = reader.ReadLine()!) != null)
                    {
                        string[] parts = Regex.Split(line, "[ ]+");
                        if (parts[6] == "Хищное")
                        {
                            list.Add(new Predator(int.Parse(parts[1]), parts[2], int.Parse(parts[3]), double.Parse(parts[4]), double.Parse(parts[5])));
                        }
                        else if (parts[6] == "Травоядное")
                        {
                            list.Add(new Omnivorous(int.Parse(parts[1]), parts[2], int.Parse(parts[3]), double.Parse(parts[4]), double.Parse(parts[5])));
                        }
                        else if (parts[6] == "Всеядное")
                        {
                            list.Add(new Herbivore(int.Parse(parts[1]), parts[2], int.Parse(parts[3]), double.Parse(parts[4]), double.Parse(parts[5])));
                        }
                        else
                        {
                            throw new Exception("Invalid animal type");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }
}

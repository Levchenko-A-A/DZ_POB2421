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
                    Animal key = list[i];
                    int j = i - 1;
                    while (j >= 0 && list[j].FoodQuantity < key.FoodQuantity)
                    {
                        list[j + 1] = list[j];
                        j--;
                    }
                    list[j + 1] = key;
                }
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j + 1].FoodQuantity == list[j].FoodQuantity)
                    {
                        if (list[j + 1].Name.CompareTo(list[j].Name) < 0)
                        {
                            Animal temp = list[j + 1];
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
                    writer.WriteLine($"{animal.Id}|{animal.Name}|{animal.Weight}|{animal.Age}|{animal.TypeOfFood}|{animal.NormOnePer}");
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
                        string[] parts = line.Split("|");
                        Animal newAnimal;
                        if (parts[4] == "Хищное")
                        {
                            newAnimal = new Predator(Convert.ToInt32(parts[0]), parts[1], Convert.ToDouble(parts[2]), Convert.ToInt32(parts[3]), Convert.ToDouble(parts[5]));
                        }
                        else if (parts[4] == "Травоядное")
                        {
                            newAnimal = new Omnivorous(Convert.ToInt32(parts[0]), parts[1], Convert.ToDouble(parts[2]), Convert.ToInt32(parts[3]), Convert.ToDouble(parts[5]));
                        }
                        else if (parts[4] == "Всеядное")
                        {
                            newAnimal = new Herbivore(Convert.ToInt32(parts[0]), parts[1], Convert.ToDouble(parts[2]), Convert.ToInt32(parts[3]), Convert.ToDouble(parts[5]));
                        }
                        else
                        {
                            throw new Exception("Invalid animal type");
                        }

                        newAnimal.Id = int.Parse(parts[0]);
                        newAnimal.Name = parts[1];
                        list.Add(newAnimal);
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HomeWork33
{
    internal class Operations
    {
        public List<string>? ListString { get; set; } = new();
        public int count;

        public Operations()
        {
            for (int i = 0; i < 3; i++)
            {
                count++;
                Console.Write("Введите " + (count) + " строку:");
                ListString.Add(Console.ReadLine()!);
            }
        }

        public void AddString()
        {
            for (int i = 0; i < 3; i++)
            {
                count++;
                Console.Write("Введите " + (count) + " строку:");
                ListString.Add(Console.ReadLine()!);
            }
        }

        public void FindList(string name)
        {
            if(ListString!.IndexOf(name)>=0)
                Console.WriteLine(ListString.IndexOf(name)+" "+ListString.Find(x => x == name));
            else Console.WriteLine("Такого значения не найдено.");
        }

        public void RemoveAtIndex()
        {
            Console.Write("Введите индекс записи, которую необходимо удалить:");
            int index;
            int.TryParse(Console.ReadLine()!, out index);
            ListString.RemoveAt(index-1);
        }

        public void Clear()
        {
            ListString.Clear();
        }

        public void SortList()
        {
            ListString.Sort();
        }

        public void FindAllValues(string name)
        {
            int[] mas = new int[ListString!.Count];
            int temp=1;
            if (ListString!.IndexOf(name) >= 0)
            {
                Console.Write("Cписок индексов вхождений:");
                for (int i = 0; i < ListString.Count; i++)
                {
                    if (ListString[i] == name)
                    {
                        mas[temp] = i;
                        
                        Console.Write(temp+" ");
                    }
                    temp++;
                }
            }
            else Console.WriteLine("Введенное содержимое не найдено.");

        }

        public void Print()
        {
            Console.WriteLine($"{ "Номер записи",13}  {"Содержимое строки"}");
            for (int i = 0; i < ListString.Count; i++)
            {
                Console.WriteLine($"{i+1,13}   {ListString[i]}");
            }
        }
    }
}

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

        public Operations()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите " + (i + 1) + " строку:");
                ListString.Add(Console.ReadLine()!);
            }
        }

        public int FindIndex(string name)
        {
            if (ListString.BinarySearch(name) >= 0)
                return ListString.BinarySearch(name);
            else return -1;
        }

        public void FindList(string name)
        {
            Console.WriteLine(ListString.BinarySearch(name)+" "+ListString.Find(x => x == name));
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
            //if (ListString.Count != 0)
            //{
            //    for (int i = 1; i < ListString.Count; i++)
            //    {
            //        List<string> key = ListString[i];
            //        int j = i - 1;
            //        while (j >= 0 && ListString[i].CompareTo(key))
            //        {
            //            ListString[j + 1] = ListString[j];
            //            j--;
            //        }
            //        ListString[j + 1] = key;
            //    }
            //}
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

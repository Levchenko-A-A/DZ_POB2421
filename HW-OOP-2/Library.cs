using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_2
{
    struct Book
    {
        public string Name { get; set; }
        public string Autor { get; set; }
        public int Year { get; set; }
    }

    internal class Library
    {
        public List<Book> Books { get; set; } = new();
        public void Add(Book book) => Books.Add(book);
        public Library(List<Book> books)
        {
            Books = books;
        }
        public void Print()
        {
            foreach(Book b in Books)
                Console.WriteLine($"{b.Name,12}{b.Autor,20}{b.Year,6}");
        }
        public void FindName(string name)
        {
            foreach (Book b in Books)
            {
                if (b.Name == name)
                Console.WriteLine($"{b.Name,12}{b.Autor,20}{b.Year,6}");
            }
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
        public void FindAutor(string name)
        {
            foreach (Book b in Books)
            {
                if (b.Autor == name)
                    Console.WriteLine($"{b.Name,12}{b.Autor,20}{b.Year,6}");
            }
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
        public void FindYear(int year)
        {
            foreach (Book b in Books)
            {
                if (b.Year == year)
                    Console.WriteLine($"{b.Name,12}{b.Autor,20}{b.Year,6}");
            }
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
        public void sortName()
        {
            for( int i=1; i<Books.Count; i++ )
            {
                Book key = Books[i];
                int j = i - 1;
                while(j>=0 && Books[i].Name.CompareTo(key.Name)>0)
                {
                    Books[j+1] = Books[j];
                    j--;
                }
                Books[j + 1] = key;
            }
        }
        public Library()
        {
        }
    }
}

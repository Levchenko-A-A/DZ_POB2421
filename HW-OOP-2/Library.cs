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

        public Library()
        {
        }
    }
}

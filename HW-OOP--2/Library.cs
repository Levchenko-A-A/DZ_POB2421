using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_OOP__2
{
    struct Book
    {
        private string? name;
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
        private string? autor;
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        private int year;
        public int Year
        {
            get { return year; }
            set { if (value > 0) year = value;
                else throw new Exception("Введите корректно дату.");
            }
        }
    }
    internal class Library
    {
        public List<Book> Books { get; set; } = new();
        //public Library()
        //{
        //}
        public void Add(Book book) => Books.Add(book);
        public void SubName(string? name)
        {
            if(FindIndexName(name)!=-1)
            Books.RemoveAll(i => i.Name == name);
            else Console.WriteLine("Книги с таким названием нет в базе:");
        }
        public void SubAutor(string? autor)
        {
            if (FindIndexAutor(autor) != -1)
                Books.RemoveAll(i => i.Autor == autor);
            else Console.WriteLine("Книги такого Автора нет в базе:");
        }
        public void SubYear(int year)
        {
            if (FindIndexYear(year) != -1)
                Books.RemoveAll(i => i.Year == year);
            else Console.WriteLine("Книги с таким годом выпуска нет в базе:");
        }
        public Library(List<Book> books)
        {
            Books = books;
        }
        public void Print()
        {
            foreach (Book b in Books)
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

        public int FindIndexName(string name)
        {
            foreach (Book b in Books)
            {
                int index = 0;
                if (b.Name == name)
                {
                    index++;
                    return index;
                }
            }
            return -1;
        }
        public int FindIndexAutor(string autor)
        {
            foreach (Book b in Books)
            {
                int index = 0;
                if (b.Autor == autor)
                {
                    index++;
                    return index;
                }
            }
            return -1;
        }
        public int FindIndexYear(int year)
        {
            foreach (Book b in Books)
            {
                int index = 0;
                if (b.Year == year)
                {
                    index++;
                    return index;
                }
            }
            return -1;
        }

        public void sortName()
        {
            for (int i = 1; i < Books.Count; i++)
            {
                Book key = Books[i];
                int j = i - 1;
                while (j >= 0 && Books[j].Name.CompareTo(key.Name) > 0)
                {
                    Books[j + 1] = Books[j];
                    j--;
                }
                Books[j + 1] = key;
            }
        }
        public void sortAutor()
        {
            for (int i = 1; i < Books.Count; i++)
            {
                Book key = Books[i];
                int j = i - 1;
                while (j >= 0 && Books[j].Autor.CompareTo(key.Autor) > 0)
                {
                    Books[j + 1] = Books[j];
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

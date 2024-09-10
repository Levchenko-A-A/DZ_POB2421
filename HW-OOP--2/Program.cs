using HW_OOP__2;
//Задание 1
//DinArray dinArray = new DinArray();
//dinArray.Print();
//dinArray.Rearrange();
//dinArray.Print();
//dinArray.DinCount();
//Задание 2
Library library = new();
for (int i = 0; i < 5; i++)
{
    Console.Write("ведите название книги:");
    string name = Console.ReadLine()!;
    Console.Write("ведите автора:");
    string autor = Console.ReadLine()!;
    Console.Write("Введите год издания:");
    int year;// = int.TryParse(Console.ReadLine()!);
    int.TryParse(Console.ReadLine()!, out year);
    library.Add(new Book() { Name = name, Autor = autor, Year = year });
}
Console.Clear();
Console.WriteLine("Исходный список");
library.Print();
Console.WriteLine("Список отсортирован по Названию Книги.");
library.sortName();
library.Print();
Console.WriteLine("Список отсортирован по Автору Книги.");
library.sortAutor();
library.Print();
Console.WriteLine("Нажмите любую клавишу.");
Console.ReadKey();
Console.Clear();
library.Print();
Console.Write("Для поиска по названию, ведите название книги:");
string nameBook = Console.ReadLine()!;
library.FindName(nameBook);
Console.Write("Для поиска по по автору, ведите автора:");
string autorBook = Console.ReadLine()!;
library.FindAutor(autorBook);
Console.Write("Для поиска по году издания, введите год издания:");
int yearBook = int.Parse(Console.ReadLine()!);
library.FindYear(yearBook);
Console.WriteLine("Нажмите любую клавишу.");
Console.Clear();
library.Print();
Console.Write("Для удаления книги по названию, ведите название книги:");
nameBook = Console.ReadLine()!;
library.SubName(nameBook);
library.Print();
Console.Write("Для удаления книги по автору, ведите автора:");
autorBook = Console.ReadLine()!;
library.SubAutor(autorBook);
library.Print();
Console.Write("Для удаления книги по году издания, введите год издания:");
yearBook = int.Parse(Console.ReadLine()!);
library.SubYear(yearBook);
library.Print();

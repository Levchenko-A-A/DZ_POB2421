﻿using HW_OOP_2;

//Console.WriteLine("Введите необходимое значение элементов массива");
//int n;
//int.TryParse(Console.ReadLine(), out n);
//DinamicArray array = new DinamicArray(n);
//Console.WriteLine("Заполненный случайными числами массив:");
//array.masRandom();
//array.masPrint();
//Console.WriteLine();
//Console.WriteLine("Перемешанный массив:");
//array.masRandomChange();
//array.masPrint();
//Console.WriteLine();
//array.masCount();

Library library = new Library();
for (int i = 0; i < 5; i++)
{
    Console.Write("ведите название книги:");
    string name = Console.ReadLine()!;
    Console.Write("ведите автора:");
    string autor = Console.ReadLine()!;
    Console.Write("Введите год издания:");
    int year = int.Parse(Console.ReadLine()!);
    library.Add(new Book() { Name = name, Autor = autor, Year = year });
}
Console.Clear();
library.sortName();
library.Print();
//library.Print();
//Console.Write("Для вывода списка по названию, ведите название книги:");
//string nameBook = Console.ReadLine()!;
//library.FindName(nameBook);
//Console.Write("Для вывода списка по автору, ведите автора:");
//string autorBook = Console.ReadLine()!;
//library.FindAutor(autorBook);
//Console.Write("Для вывода списка по году издания, введите год издания:");
//int yearBook = int.Parse(Console.ReadLine()!);
//library.FindYear(yearBook);

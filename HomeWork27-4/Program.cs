

using HomeWork27_4;
using System;
Numbers numbers = new Numbers();
int num;
int num2;
Console.WriteLine("\nМетод вычисления факториала числа:");
Console.Write("Введите число:");
int.TryParse(Console.ReadLine()!, out num);
Console.WriteLine($"Факториал Числа: {numbers.CalculateFactorial(num)}");

Console.WriteLine("\nМетод преобразования в двоичное представление:");
Console.Write("Введите число:");
int.TryParse(Console.ReadLine()!, out num);
Console.WriteLine($"Двоичное представление: {numbers.ConvertToBinary(num)}");

Console.WriteLine("\nМетод преобразования в двоичное представление:");
Console.Write("Введите число:");
int.TryParse(Console.ReadLine()!, out num);
Console.WriteLine($"Шестнадцатеричное представление: {numbers.ConvertToHex(num)}");

Console.WriteLine("\nМетод возведения в степень:");
Console.Write("Введите основание:");
int.TryParse(Console.ReadLine()!, out num);
Console.Write("Введите степень:");
int.TryParse(Console.ReadLine()!, out num2);
Console.WriteLine($"Результат возведения в степень: {numbers.CalculatePower(num, num2)}");
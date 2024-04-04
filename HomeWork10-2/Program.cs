//Написать программу, которая запрашивает у пользователя значение
//катета и гипотенузы прямоугольного треугольника, а затем выводит на
//экран значение второго катета, вычисленное с помощью методов класса
//Math.

Console.Write("Введите значение 1-ого катета: ");
double firstLeg = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение гипотенузы:");
double hypotenuse = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Значение 2-ого катета: {Math.Round(Math.Sqrt(Math.Pow(hypotenuse,2)-Math.Pow(firstLeg,2)),2)}");
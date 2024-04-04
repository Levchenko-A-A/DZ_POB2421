//Написать программу, которая запрашивает у пользователя значение
//радиуса окружности и выводит на экран ее длину и площадь,
//вычисленные с помощью методов класса Math.

Console.Write("Введите Радиус окружности: ");
double R = double.Parse(Console.ReadLine());
Console.WriteLine($"Длина окружности L = {Math.Round(2*Math.PI*R,2)}");
Console.WriteLine($"Площадь окружности S = {Math.Round(Math.PI*Math.Pow(R,2),2)}");
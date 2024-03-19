// See https://aka.ms/new-console-template for more information
Console.Write("Введите значение в мм: ");
double mm = double.Parse(Console.ReadLine());


Console.WriteLine($"Значение в сантиметрах: {mm/10} см");
Console.WriteLine($"Значение в метрах: {mm / 1000} м");
Console.WriteLine($"Значение в километрах: {mm / 1000000} км");
Console.ReadLine();

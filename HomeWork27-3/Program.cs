using HomeWork27_3;
Numbers numbers = new Numbers();
int num;
Console.WriteLine("Метод - среднее арифметическое:");
Random random = new Random();
double[] mas=new double[random.Next(6,11)];
numbers.GeneretAverage(mas);
Console.WriteLine($"\nСреднее арифметическое: {numbers.CalculateAverage(mas):F2}\n");

Console.WriteLine("Метод, определяющий простое число:");
Console.Write("Введите число:");
int.TryParse(Console.ReadLine()!, out num);
if (numbers.IsPrime(num)) Console.WriteLine("Число простое.");
else Console.WriteLine("Число не простое");

Console.WriteLine("\nМетод, определяющий четность числи:");
Console.Write("Введите число:");
int.TryParse(Console.ReadLine()!, out num);
if (numbers.IsEven(num)) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");

Console.WriteLine("\nМетод, определяющий четность числи:");
Console.Write("Введите число:");
int.TryParse(Console.ReadLine()!, out num);
if (numbers.IsOdd(num)) Console.WriteLine("Число нечетное");
else Console.WriteLine("Число четное");
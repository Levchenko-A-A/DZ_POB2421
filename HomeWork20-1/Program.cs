
Console.Write("Введите первое число:");
double fistNumber=double.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
double secondNumber = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма двух чисел: {Summ(fistNumber, secondNumber):F2}");

double Summ(double a, double b)
{
    return a + b;
}
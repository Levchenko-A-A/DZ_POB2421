//Задание 1.
//Напишите функцию, которая принимает два числа и выводит на экран их
//сумму.
//Числа передаются пользователем в переменные, которые затем
//передаются в функцию.
//Функция должна возвращать результат, который в последствии выводится
//на консоль.

Console.Write("Введите первое число:");
double fistNumber = double.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
double secondNumber = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма двух чисел: {Summ(fistNumber, secondNumber):F2}");

double Summ(double a, double b)
{
    return a + b;
}

//Задание 2.
//Напишите функцию, которая принимает массив целых чисел и возвращает
//среднее значение элементов массива.
//Массив задать явно
//Функция должна возвращать результат, который в последствии выводится
//на консоль.

Random random = new Random();
int[] mas = new int[random.Next(5, 11)];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10, 100);
    Console.Write(mas[i] + " ");
}
Console.WriteLine($"Среднее арифметическое {summMas(mas):F2}");

double summMas(int[] mas)
{
    double s = 0;
    for (int i = 0; i < mas.Length; i++)
        s += mas[i];
    return s / mas.Length;
}
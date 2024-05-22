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
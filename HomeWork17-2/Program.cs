int count = 0;
int sum = 0;
double sumAll = 0;
Random random = new Random();
int[][] array = new int[3][];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new int[random.Next(5, 11)];
}
Console.WriteLine("Сформированный массив:");

for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array[i].Length; j++)
    {
        array[i][j] = random.Next(1, 11);
        Console.Write(array[i][j] + " ");
        count++;
    }
    Console.WriteLine();
}
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array[i].Length; j++)
    {
        sum += array[i][j];
        sumAll += array[i][j];
    }
    Console.WriteLine($"Сумма {i+1} массива: {sum}");
    sum = 0;
}
Console.WriteLine($"Среднее арифметическое всех значений массива: {sumAll/count:F2}");
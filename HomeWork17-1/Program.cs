Random random = new Random();
int[][] array=new int[random.Next(3,11)][];
for(int i=0; i < array.Length; i++)
{
    array[i] = new int[random.Next(5, 21)];
}
Console.WriteLine("Сформированный массив:");
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array[i].Length; j++)
    {
        array[i][j] = random.Next(1,11);
        Console.Write(array[i][j]+" ");
    }
    Console.WriteLine();
}
Console.Write("Введите индексы ячейки массива для замены на число 200 через запятую:");
string strNumbers = Console.ReadLine();
string[] numbers = strNumbers.Split(",");
array[int.Parse(numbers[0])][int.Parse(numbers[1])] = 200;
Console.WriteLine("Массив после изменения:");
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array[i].Length; j++)
    {
        Console.Write(array[i][j] + " ");
    }
    Console.WriteLine();
}
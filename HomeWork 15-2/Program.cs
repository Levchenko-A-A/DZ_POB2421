int[] mas= new int[10];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(101);
    Console.Write(mas[i]+" ");
}
int count = 0;
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] % 2 == 0) count++;  
}
Console.WriteLine();
Console.WriteLine($"Колличество четных чисел: {count}");
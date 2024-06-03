
int[,] masFirst = new int[4,4];
int[,] masSecond = new int[4,4];
int[,] masThird = new int[4, 4];
CompletMas(masFirst);

Console.Write("Первый массив:");
CompletMas(masFirst);
PrintMas(masFirst);
Console.Write("Второй массив:");
CompletMas(masSecond);
PrintMas(masSecond);
Console.Write("Массив суммы двух предыдущих:");
MasSumm(masFirst, masSecond, masThird);
PrintMas(masThird);
Console.WriteLine($"Максимальное значение Первого массива: {FindMax(masFirst)}");
Console.WriteLine($"Максимальное значение Второго массива: {FindMax(masSecond)}");
Console.WriteLine($"Максимальное значение Третьего массива: {FindMax(masThird)}");


void CompletMas(int[,] nameMas)
{
    Random random = new Random();
    for (int i = 0; i < nameMas.GetLength(0); i++)
        for (int j = 0; j < nameMas.GetLength(1); j++)
            nameMas[i, j] = random.Next(-50, 51);
}

void PrintMas(int[,] nameMas)
{
    for (int i = 0; i < nameMas.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < nameMas.GetLength(1); j++)
            Console.Write(nameMas[i, j]+ " ");
    }
    Console.WriteLine();
}
void MasSumm(int[,] nameMas1, int[,] nameMas2, int[,] nameMas3)
{
    if((nameMas1.GetLength(0) ==  nameMas2.GetLength(0))&&(nameMas1.GetLength(0) == nameMas2.GetLength(0)))
    for (int i = 0; i < nameMas1.GetLength(0); i++)
        for (int j = 0; j < nameMas1.GetLength(1); j++)
                nameMas3[i,j]= nameMas1[i,j]+nameMas2[i,j];
}

int FindMax(int[,] nameMas)
{
    int temp = int.MinValue;
    for (int i = 0; i < nameMas.GetLength(0); i++)
        for (int j = 0; j < nameMas.GetLength(1); j++)
            if (temp < nameMas[i, j])
                temp = nameMas[i, j];
    return temp;
}
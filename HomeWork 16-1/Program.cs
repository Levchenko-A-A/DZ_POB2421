//1.Создать двумерный массив 3х3. Заполнить его дробными числами от
//0 до 20.
//Оформить вывод на экран всех чисел.
//Добавить возможность замены значения пользователем.
//Вывод нового массива.

//double[,] array = new double[3, 3];
//Random random = new Random();
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array[i, j] = random.NextDouble()*100/5;
//    }
//}
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write($"{(array[i,j]),5:F2} "); ;
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.WriteLine("Для замены одного значения введите:");
//int indexOne = 0;
//int indexTwo = 0;
//Console.Write("Номер строки: ");
//indexOne=int.Parse(Console.ReadLine()!);
//Console.Write("Номер столбца: ");
//indexTwo = int.Parse(Console.ReadLine()!);
//Console.WriteLine("Новое значение: ");
//array[indexOne-1, indexTwo-1] = double.Parse(Console.ReadLine()!);
//Console.WriteLine();
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write($"{(array[i, j]),5:F2} "); ;
//    }
//    Console.WriteLine();
//}

//2.Создать массив символов 5х2.
//Заполнить его символами по желанию в разнобой.
//Вывести на экран понятное слово.

string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
char[,] array = new char[5, 2];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = symbols[random.Next(symbols.Length)];
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
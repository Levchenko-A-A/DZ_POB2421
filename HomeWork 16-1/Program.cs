//1.Создать двумерный массив 3х3. Заполнить его дробными числами от
//0 до 20.
//Оформить вывод на экран всех чисел.
//Добавить возможность замены значения пользователем.
//Вывод нового массива.

double[,] array = new double[3, 3];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.NextDouble() * 100 / 5;
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{(array[i, j]),5:F2} "); ;
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Для замены одного значения введите:");
int indexOne = 0;
int indexTwo = 0;
Console.Write("Номер строки от 1 до 3: ");
indexOne = int.Parse(Console.ReadLine()!);
Console.Write("Номер столбца от 1 до 3: ");
indexTwo = int.Parse(Console.ReadLine()!);
Console.WriteLine("Новое значение: ");
array[indexOne - 1, indexTwo - 1] = double.Parse(Console.ReadLine()!);
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{(array[i, j]),5:F2} "); ;
    }
    Console.WriteLine();
}

//2.Создать массив символов 5х2.
//Заполнить его символами по желанию в разнобой.
//Вывести на экран понятное слово.

//string symbols = "йцукенгшщзхъфывапролджэячсмитьбюЦУКЕНГШЩЗХФВАПРОЛДЖЭЯЧСМИТБЮ";
char[,] array1 = { { 'А', 'о' },
                   { 'Т', 'б' },
                   { 'р', 'а' },
                   { 'и', 'к' },
                   { 'К', 'а' } };

Console.WriteLine("Вывод на экран массива:\n");
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        Console.Write(array1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
string str = null;
str += char.ToString(array1[0, 0]);
str += char.ToString(array1[3, 1]);
str += char.ToString(array1[2, 0]);
str += char.ToString(array1[0, 1]);
str += char.ToString(array1[1, 1]);
str += char.ToString(array1[4, 1]);
str += char.ToString(array1[1, 0]);
str += char.ToString(array1[3, 0]);
str += char.ToString(array1[4, 0]);
str += char.ToString(array1[2, 1]);

Console.WriteLine();
Console.WriteLine($"\nВывод на экран слова: {str}");

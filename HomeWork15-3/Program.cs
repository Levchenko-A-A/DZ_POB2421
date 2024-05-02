//Напишите программу, которая запрашивает у пользователя 10 целых
//чисел и сохраняет их в массиве. Затем программа сортирует массив по
//возрастанию и выводит отсортированный массив на экран. Далее
//программа запрашивает у пользователя число и находит его индекс в
//массиве. Если число не найдено, программа выводит сообщение об
//ошибке.

int[] mas = new int[10];
Console.WriteLine("Необходимо ввести 10 целых чисел:");
for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"Введите {i+1} значение: ");
    mas[i] = int.Parse(Console.ReadLine());
}
Array.Sort(mas);
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i]+" ");
}
Console.WriteLine("Введите число из массива:");
int number=int.Parse(Console.ReadLine());
Console.WriteLine();
string index = "";
for (int i = 0; i < mas.Length; i++)
{
    if (number == mas[i])
    {
        index += i;
        index += " ";
    }
}
Console.WriteLine($"Индекс(ы) запрошенного числа: {index}");
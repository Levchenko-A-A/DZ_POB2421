Console.Write("Введите список чисел через пробел:");
string listNumber = Console.ReadLine()!;
try
{
    string[] strings = listNumber.Split(' ');
    foreach (string s in strings)
        Console.Write(s + " ");
    double result = 0;
    for (int i = 0; i < strings.Length; i++)
        result += Convert.ToDouble(strings[i]);
    Console.WriteLine(result);
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: некорректный ввод. Пожалуйста, введите только числа, разделенные пробелами.");
}
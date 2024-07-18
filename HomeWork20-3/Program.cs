bool tmp = true;
do
{
    Console.WriteLine("Меню:");
    Console.WriteLine("1. Логическое умножение.");
    Console.WriteLine("2. Логическое сложение.");
    Console.WriteLine("3. Логическое исключение.");
    Console.WriteLine("4. Выход.");
    Console.Write("Ваш выбор:");
    int choice;
    int.TryParse(Console.ReadLine(), out choice);
    switch (choice)
    {
        case 1:
            {
                Console.Write("Введите первое число:");
                int namberOne;
                int.TryParse(Console.ReadLine()!, out namberOne);
                Console.Write("Введите первое число:");
                int namberTwo;
                int.TryParse(Console.ReadLine()!, out namberTwo);
                BinMul(namberOne, namberTwo);
                Console.ReadKey();
                Console.Clear();
            }
            break;
        case 2:
            {
                Console.Write("Введите первое число:");
                int namberOne;
                int.TryParse(Console.ReadLine()!, out namberOne);
                Console.Write("Введите первое число:");
                int namberTwo;
                int.TryParse(Console.ReadLine()!, out namberTwo);
                BinSum(namberOne, namberTwo);
                Console.ReadKey();
                Console.Clear();
            }
            break;
        case 3:
            {
                Console.Write("Введите первое число:");
                int namberOne;
                int.TryParse(Console.ReadLine()!, out namberOne);
                Console.Write("Введите ключ:");
                int namberTwo;
                int.TryParse(Console.ReadLine()!, out namberTwo);
                BinExceptionKey(namberOne, namberTwo);
                Console.ReadKey();
                Console.Clear();
            }
            break;
        case 4: tmp=false; break;
    }
} while (tmp);


void BinSum(int value1,  int value2)
{
    value1 = 8;
    value2 = 3;
    string binary1 = Convert.ToString(value1, 2);
    string binary2 = Convert.ToString(value2, 2);
    Console.WriteLine($"DEC: {value1,6}\n" +
                      $"DEC: {value2,6}\n" +
                      $"BIN: {binary1,6}\n" +
                      $"BIN: {binary2,6}\n" +
                      $"Результат &:\n" +
                      $"DEC: {value1 & value2,6}\n" +
                      $"BIN: {Convert.ToString(value1 & value2, 2),6}\n");
}
void BinMul(int value1, int value2)
{
    value1 = 65;
    value2 = 29;
    string binary1 = Convert.ToString(value1, 2);
    string binary2 = Convert.ToString(value2, 2);
    Console.WriteLine($"DEC: {value1,7}\n" +
                      $"DEC: {value2,7}\n" +
                      $"BIN: {binary1,7}\n" +
                      $"BIN: {binary2,7}\n" +
                      $"Результат |:\n" +
                      $"DEC: {value1 | value2,7}\n" +
                      $"BIN: {Convert.ToString(value1 | value2, 2),7}\n");
}
void BinExceptionKey (int value1, int value2)
{
    Console.WriteLine("Задача 3");
    value1 = 249;
    int key = 8;
    value2 = value1 ^ key;
    string binary1 = Convert.ToString(value1, 2);
    string binary2 = Convert.ToString(key, 2);
    Console.WriteLine($"DEC: {value1,8}\n" +
                      $"DEC: {key,8}\n" +
                      $"BIN: {binary1,8}\n" +
                      $"BIN: {binary2,8}\n" +
                      $"Результат 249^8:\n" +
                      $"DEC: {value1 ^ key,8}\n" +
                      $"BIN: {Convert.ToString(value1 ^ key, 2),8}\n" +
                      $"Обратное исключение:\n" +
                      $"DEC: {value2 ^ key,8}\n" +
                      $"BIN: {Convert.ToString(value2 ^ key, 2),8}\n");
}
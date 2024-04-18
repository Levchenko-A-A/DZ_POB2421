Console.Write("Введите число 1: ");
double numberOne = double.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
double numberTwo = double.Parse(Console.ReadLine()!);
Console.WriteLine("Выберите математическую операцию:\n" +
                  "1 - Cложение \"+\"\n" +
                  "2 - Вычитание \"-\"\n" +
                  "3 - Умножение \"*\"\n" +
                  "4 - Деление \"\\\"");
int operation=int.Parse(Console.ReadLine()!);
switch (operation)
{
    case 1: Console.WriteLine($"Результат сложения: {numberOne + numberTwo}"); break;
    case 2: Console.WriteLine($"Результат сложения: {numberOne - numberTwo}"); break;
    case 3: Console.WriteLine($"Результат сложения: {numberOne * numberTwo}"); break;
    case 4:
        {
            if (numberTwo == 0)
            {
                Console.WriteLine("Введен не корректно делитель, делить на 0 нельзя");
                break;
            }
            else
            {
                Console.WriteLine($"Результат сложения: {numberOne / numberTwo}");
                break;
            }
        }
}
//1.Сгенерировать случайное целое число в диапазоне от 0 до 5, запросить
//еще одно число у пользователя и в случае совпадения вывести на экран
//информацию о победе, в противном случае - поражении.

Random random = new Random();
int numberOne = random.Next(0, 5 + 1);
Console.Write("Введите целое число: ");
int numberTwo = int.Parse(Console.ReadLine()!);
if (numberTwo == numberOne) Console.WriteLine($"Вы угадали. Компьютер загадал {numberOne}");
else Console.WriteLine($"Вы не угадали. Компьютер загадал {numberOne}");

//2.Запросить у пользователя порядковый номер текущего месяца и
//вывести его название.
//* Если пользователь указал месяц из зимнего периода, а средняя
//температура > 0, вывести сообщение «Дождливая зима».

Console.Write("Введите номер месяца от 1 до 12: ");
int month = int.Parse(Console.ReadLine()!);
if (month == 12 || month == 1 || month == 2)
{
    Console.Write("Введите среднюю температуру: ");
    double averTemp = double.Parse(Console.ReadLine()!);
    switch (month)
    {
        case 1: Console.WriteLine((averTemp > 0) ? "Январь. \"Дождливая зима\"" : "Январь"); break;
        case 2: Console.WriteLine((averTemp > 0) ? "Февраль. \"Дождливая зима\"" : "Февраль"); break;
        case 12: Console.WriteLine((averTemp > 0) ? "Декабрь. \"Дождливая зима\"" : "Декабрь"); break;
    }
}
else if (month >= 3 || month <= 11)
{
    switch (month)
    {
        case 3: Console.WriteLine("Март"); break;
        case 4: Console.WriteLine("Апрель"); break;
        case 5: Console.WriteLine("Май"); break;
        case 6: Console.WriteLine("Июнь"); break;
        case 7: Console.WriteLine("Июль"); break;
        case 8: Console.WriteLine("Август"); break;
        case 9: Console.WriteLine("Сентябрь"); break;
        case 10: Console.WriteLine("Октябрь"); break;
        case 11: Console.WriteLine("Ноябрь"); break;
    }
}


//Незнайка

Console.Write("Введите Ваш возраст: ");
int age = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Кандидаты в президенты солнечного города:\n" +
                  $"1 - Незнайка\n" +
                  $"2 - Лунтик\n" +
                  $"3 - Карлсон\n" +
                  $"4 - Дядя Фёдор");
Console.Write("За кого Вы будете болеть: ");
int choice = int.Parse(Console.ReadLine()!);
if (age < 18) Console.WriteLine("Вы слишком молоды для участия в выборах");
else if (age >= 18 && age <= 35) Console.WriteLine("Вы можете учавствовать в выборах в качестве депутата");
else if (age >= 36 && age <= 65) Console.WriteLine("Вы можете учавствовать в выборах в качестве кандидата в президенты");
else Console.WriteLine("Ваш возраст слишком велик для участия в выборах");
switch (choice)
{
    case 1: Console.WriteLine("В траве сидел компьютер, зелёненький он был! И всё он перепутал, и всё перезабыл!"); break;
    case 2: Console.WriteLine("Если здесь есть растения, значит, есть и воздух... апчхи!... А если есть воздух... то есть и лунатики!"); break;
    case 3: Console.WriteLine("Торопыжка был голодный, проглотил утюг холодный."); break;
    case 4: Console.WriteLine("Сейчас как треснемся об Луну, и привет Ромашке."); break;
}

//Задача на 10-ку 1

Random random = new Random();
int month = random.Next(1, 13);
Console.Write("Введите количество дней в загаданном месяце: ");
int daysInMonthUser = int.Parse(Console.ReadLine());
if (daysInMonthUser == System.DateTime.DaysInMonth(2024, month)) Console.WriteLine("Победа!!!");
else Console.WriteLine($"Компьютер загадал {System.DateTime.DaysInMonth(2024, month)} количество дней.");



//Задача на 10-ку 2

Random random2 = new Random();
int month2 = random2.Next(1, 13);
switch (month2)
{
    case 1: Console.WriteLine($"Компьютер загадал: Январь"); break;
    case 2: Console.WriteLine($"Компьютер загадал: Февоаль"); break;
    case 3: Console.WriteLine($"Компьютер загадал: Март"); break;
    case 4: Console.WriteLine($"Компьютер загадал: Апрель"); break;
    case 5: Console.WriteLine($"Компьютер загадал: Май"); break;
    case 6: Console.WriteLine($"Компьютер загадал: Июнь"); break;
    case 7: Console.WriteLine($"Компьютер загадал: Июль"); break;
    case 8: Console.WriteLine($"Компьютер загадал: Август"); break;
    case 9: Console.WriteLine($"Компьютер загадал: Сентябрь"); break;
    case 10: Console.WriteLine($"Компьютер загадал: Октябрь"); break;
    case 11: Console.WriteLine($"Компьютер загадал: Ноябрь"); break;
    case 12: Console.WriteLine($"Компьютер загадал: Декабрь"); break;
}
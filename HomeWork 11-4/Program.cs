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
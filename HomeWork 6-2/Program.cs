
Console.Write("Введите Фамилию: ");
string surName = Console.ReadLine()!;
Console.Write("Введите Имя: ");
string nAme = Console.ReadLine()!;
Console.Write("Введите Ваш возраст: ");
int aGe = int.Parse(Console.ReadLine()!);
Console.Write("Введите Ваш рост: ");
int heIght = int.Parse(Console.ReadLine()!);


string newString = String.Join(" ", surName, nAme, aGe.ToString(), heIght.ToString());
Console.WriteLine(newString);

Console.WriteLine($"\nТип данных переменной surName: {surName.GetType()}\n" +
    $"Тип данных переменной nAme: {nAme.GetType()}\n" +
    $"Тип данных переменной aGe: {aGe.GetType()}\n" +
    $"Тип данных переменной heIght: {heIght.GetType()}\n");
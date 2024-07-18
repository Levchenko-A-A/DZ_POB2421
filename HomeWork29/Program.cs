foreach(Month items in Enum.GetValues(typeof(Month)))
{
    Console.WriteLine($"{(items)} {items,-10} {Enum.Format(typeof(Month), items,"D"),4}");
}

Console.Write("Введите порядковый номер месяца:");
int number;
int.TryParse(Console.ReadLine(), out number);
if (!Enum.IsDefined(typeof(Month), number))
    Console.WriteLine($"Значения {number} нет в перечислении");
else Console.WriteLine($"Введенный месяц: {Enum.GetName(typeof(Month),number)}");

enum Month : int
{
    January=1,
    February=2,
    March=3,
    April=4,
    May=5,
    June=6,
    July=7,
    August=8,
    September=9,
    October=10,
    November=11,
    December=12
}
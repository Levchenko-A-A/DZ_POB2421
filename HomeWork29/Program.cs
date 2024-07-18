foreach(Month items in Enum.GetValues(typeof(Month)))
{
    Console.WriteLine($"{Enum.Format(typeof(Month),items,"G"),10} {Enum.Format(typeof(Month), items,"D"),4}");
}



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
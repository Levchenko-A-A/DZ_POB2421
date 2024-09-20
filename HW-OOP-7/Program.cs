using HW_OOP_7;

List<Liquid> liquids = new List<Liquid>();
liquids.Add(new Liquid()
{
    Name = "Вода",
    Density = 1
});
liquids.Add(new Liquid()
{
    Name = "Смоляное масло",
    Density = 0.96
});
liquids.Add(new Liquid()
{
    Name = "Бром",
    Density = 3.12
});
liquids.Add(new Alcohol()
{
    Name = "Вино",
    Density = 1.38,
    Fortress = 13.2
});
liquids.Add(new Alcohol()
{
    Name = "Спирт",
    Density = 0.81,
    Fortress = 96
});

foreach (Liquid liq in liquids)
{
    if (liq is Alcohol)
        Console.WriteLine($"{liq.Name,-18}{liq.Density,-6}{((Alcohol)liq).Fortress,-8}");
    else
        Console.WriteLine($"{liq.Name,-18}{liq.Density,-6}");
}


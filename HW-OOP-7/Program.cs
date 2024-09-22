using HW_OOP_7;
using System.Collections.Generic;

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
StaticChange.Print(liquids);
StaticChange.ChangeName(liquids, "Вино", "Бренди");
StaticChange.Print(liquids);
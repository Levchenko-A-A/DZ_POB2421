using HW_OOP_7;
using System.Collections.Generic;

List<Liquid> liquids = new List<Liquid>();
liquids.Add(new Liquid("Вода",1));
liquids.Add(new Liquid("Смоляное масло",0.96));
liquids.Add(new Liquid("Бром",3.12));
liquids.Add(new Alcohol("Вино", 1.38, 13.2));
liquids.Add(new Alcohol("Спирт",0.81,96));
StaticChange.Print(liquids);
for(int i = 0; i < liquids.Count; i++)
{
    Liquid tmp1=new Liquid();
    Alcohol tmp2 = new Alcohol();
    tmp1 = liquids[i];
    tmp2.Name = liquids[i].Name;
    tmp2.Density = liquids[i].Density;
    if (liquids[i] is Liquid && tmp1.Name == "Бром")
    {
        tmp1.ChangeDensity(5.12);
        liquids[i] = tmp1;
    }
    else if(liquids[i] is Alcohol && tmp2.Name == "Вино")
    {
        tmp2.ChangeFortress(15.2);
        liquids[i] = tmp2;
    }    
}
StaticChange.Print(liquids);
StaticChange.ChangeName(liquids, "Вино", "Бренди");
StaticChange.Print(liquids);

//Задание2
Console.WriteLine();
Pair pair = new Pair(10,12);
Rectangle rectangle = new Rectangle(10,12);
Console.WriteLine($"Произведение двух чисел {pair.First}*{pair.Second} = {pair.Mul()}");
Console.WriteLine($"Периметр прямоугольника со сторонами {rectangle.First} и {rectangle.Second} = {rectangle.Perimeter()}");
Console.WriteLine($"Площадь прямоугольника со сторонами {rectangle.First} и {rectangle.Second} = {rectangle.Square()}");
Console.WriteLine($"Площадь прямоугольника со сторонами {rectangle.First} и {rectangle.Second} = {rectangle.Mul()}");
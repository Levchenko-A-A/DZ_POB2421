using HW_OOP_6;
using System.Collections.Concurrent;
//Задание 1
double[] mas = new double[50];
StaticMas.FillMas(mas);
StaticMas.PrintMas(mas);
Console.WriteLine($"Среднее значение масива: {StaticMas.GetAvgNumber( mas ):F2}");
//Задание 2
string[] str = new string[10];
StaticString.FillString(str);
StaticString.PrintStringMas(str);
StaticString.ChangeStringMas(str);
StaticString.PrintStringMas(str);

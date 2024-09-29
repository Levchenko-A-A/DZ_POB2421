using HW_OOP_12;
using System.Numerics;
using System.Security.Cryptography;

Point3D point2 = new Point3D(7, 3, 15);
Point3D point3 = new Point3D(-5, 10, 3);
Console.WriteLine($"Длина вектора:{Point3D.LengsVector(point2)}");
Console.WriteLine($"Модуль вектора:{Math.Round(Point3D.ABC(point3),2)}");
Point3D pointSum = point2 + point3;
Console.WriteLine($"Сумма векторов:\n{pointSum}");
Console.WriteLine($"Скалярное произведене векторов: {Math.Round(point2*point3,2)}");
Console.WriteLine($"Угол между векторами: {Math.Round(point2*point3/(Point3D.ABC(point2)*Point3D.ABC(point3)),2)}");

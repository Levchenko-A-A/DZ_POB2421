﻿//Задание 1
Random rnd = new Random();
int temperature = 0;
for (int i = 1; ; i++)
{
    temperature = rnd.Next(1, 101);
    Console.Write(temperature + " ");
    if (temperature > 90)
    {
        Console.WriteLine($"\nКритическая температура: {temperature}\n" +
                          $"Температура превысила критический отметку, устройство остановлено.");
        break;
    }
}



//Задание 2
Console.Write("Укажите количество квадратов: ");
int quantity = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите сторону квадрата: ");
int weigth = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < quantity; i++)                      //внешний цикл, который позволяет отрисовать количество квадратов, введенное в quantity 

{
    for (int j = 0; j < weigth; j++)                    //Отрисовка верхней границы квадрата
    {
        Console.Write("*");                             //по горизонтали отрисовывается "* ". Звездочка и пробел
        Console.Write(" ");
    }
    Console.WriteLine();                                //После отрисовки верхней границы переход на новую строчку.
    for (int k = 0; k < weigth - 2; k++)                //отрисовка боковых  границ квадрата
    {
        Console.Write("*");
        for (int l = 0; l < weigth + weigth - 2; l++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
        Console.WriteLine();                            //После отрисовки боковых стенок переход на новую строчку.
    }
    for (int m = 0; m < weigth; m++)                    //Отрисовка нижней границы квадрата
    {
        Console.Write("*");                             //по горизонтали отрисовывается "* ". Звездочка и пробел
        Console.Write(" ");
    }

    Console.WriteLine();                                //при отрисовки 2-х и более квадратов, после отрисовки текущего, переходит на новую строку, перед рисовкой следующего
}

//Программа имеет два цикла, внутренний при помощи 3-х цилов for отрисовывает верхную чать квадрата, боковые стенки и нижнюю часть квадрата.
//Если пользователь выбрет 2 и более квадрата, то внешний цикл после перехода на новую строку снова запускает внутренний цикл.
﻿

const int vaT18 = 18;            // Ставка НДС 18
const int vaT10 = 10;            // Ставка НДС 18
Console.Write("Введите стоимость первого продукта: ");
double priCe1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите количество первого продукта: ");
double amt1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите стоимость второго продукта: ");
double priCe2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите количество первого продукта: ");
double amt2 = double.Parse(Console.ReadLine()!);
double tot1 = priCe1 * amt1;
double tot2 = priCe2 * amt2;
double totSum = tot1 + tot2;
Console.WriteLine($"N Название             Цена     Кол.    Сумма\n" +
                  $"1 КОФЕ Стандартный    {priCe1,-9:F2}{amt1,-9:F2}{tot1,-9:F2}\n" +
                  $"  НДС с расчитанной                     {tot1 * vaT18 / (100 + vaT18):F2}\n" +
                  $"  ставкой 18%\n\n" +
                  $"2 РУЛЕТ-СПРИНГ ТВ ИЗ  {priCe2,-9:F2}{amt2,-9:F2}{tot2,-9:F2}\n" +
                  $"  КУ\n" +
                  $"  НДС с расчитанной                     {tot2 * vaT10 / (100 + vaT10):F2}\n" +
                  $"  ставкой 10%\n\n\n" +
                  $"----------------------------------------------\n\n" +
                  $"Итого:                                  {totSum:F2}\n" +
                  $"Электронные средства                    {totSum:F2}\n" +
                  $"  НДС с расчитанной                     {tot1 * vaT18 / (100 + vaT18):F2}\n" +
                  $"18%\n" +
                  $"  НДС с расчитанной                     {tot2 * vaT10 / (100 + vaT10):F2}\n" +
                  $"10%\n\n\n" +
                  $"----------------------------------------------\n" +
                  $"ВИД НАЛОГООБЛАЖЕНИЯ: ОСН\n" +
                  $"РЕГ. НОМЕР ККТ: 0000143873023483\n" +
                  $"ЗАВОД. N.\n" +
                  $"ФД N: 8710000100265168\n" +
                  $"ФД N: 6026\n" +
                  $"ФПД: 3322278314");
Console.ReadLine();

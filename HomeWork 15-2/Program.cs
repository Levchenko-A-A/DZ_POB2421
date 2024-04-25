int[] mas= new int[10];                                             //создание массива из 10 ячеек
Random random = new Random();
for (int i = 0; i < mas.Length; i++) mas[i] = random.Next(101);     //заполнение массива случайными числами
for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");   //вывод на экран массива отдельным циклом
int count = 0;                                                      //счеткик четных чисел
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] == 0) continue;
    if (mas[i] % 2 == 0)                                            //проверка в цикле количества четных чисел в массиве
        count++;  
}
    Console.WriteLine();
Console.WriteLine($"Колличество четных чисел: {count}");            //вывод на экран количество четных чисел

//Написав код программы без перехода к описанию, увидел, что не сделал проверку на 0, добавил
int[] mas= new int[10];                                             //сохдание массива из 10 ячеек
Random random = new Random();
for (int i = 0; i < mas.Length; i++) mas[i] = random.Next(101);     //заполнение массива случайными числами
for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");   //вывод на экран массива отдельным циклом
int count = 0;                                                      //счеткик четных чисел
for (int i = 0; i < mas.Length; i++) if (mas[i] % 2 == 0) count++;  //проверка в цикле количества четных чисел в массиве
Console.WriteLine();
Console.WriteLine($"Колличество четных чисел: {count}");            //вывод на экран количество четных чисел
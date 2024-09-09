

using HomeWork33_2;
using System.Diagnostics;
Sort sort = new Sort();
Stopwatch stpWatch1 = new Stopwatch();
Stopwatch stpWatch2 = new Stopwatch();
Stopwatch stpWatch3 = new Stopwatch();
Stopwatch stpWatch4 = new Stopwatch();
Stopwatch stpWatch5 = new Stopwatch();
int[] mas = new int[100000];
int count = 100;
Random rand = new Random();

for (int i = 0; i < mas.Length; i++) mas[i] = rand.Next(count);
//sort.Print(mas);
Console.WriteLine("Пузырьковая сортировка:\n");
stpWatch1.Start();
sort.BubbleSort(mas);
stpWatch1.Stop();
Console.WriteLine("Bubble Sort StopWatch: " + (stpWatch1.ElapsedMilliseconds / 1000.0).ToString());
//sort.Print(mas);
sort.BubbleSortReverse(mas);
//sort.Print(mas);

Console.WriteLine("Сортировка выбором:\n");
for (int i = 0; i < mas.Length; i++) mas[i] = rand.Next(count);
//sort.Print(mas);
stpWatch2.Start();
sort.SelectionSort(mas);
stpWatch2.Stop();
Console.WriteLine("Selection Sort StopWatch: " + (stpWatch2.ElapsedMilliseconds / 1000.0).ToString());
//sort.Print(mas);
sort.SelectionSortReverse(mas);
//sort.Print(mas);

Console.WriteLine("Сортировка вставкой:\n");
for (int i = 0; i < mas.Length; i++) mas[i] = rand.Next(count);
//sort.Print(mas);
stpWatch3.Start();
sort.InsertionSort(mas);
stpWatch3.Stop();
Console.WriteLine("Insertion Sort StopWatch: " + (stpWatch3.ElapsedMilliseconds / 1000.0).ToString());
//sort.Print(mas);
sort.InsertionSortReverse(mas);
//sort.Print(mas);

Console.WriteLine("Cортировка слиянием:\n");
for (int i = 0; i < mas.Length; i++) mas[i] = rand.Next(count);
//sort.Print(mas);
stpWatch4.Start();
sort.MergeSort(mas, 0, mas.Length - 1);
stpWatch4.Stop();
Console.WriteLine("Merge Sort StopWatch: " + (stpWatch4.ElapsedMilliseconds / 1000.0).ToString());
//sort.Print(mas);
sort.MergeSortRevers(mas, 0, mas.Length - 1);
//sort.Print(mas);

Console.WriteLine("Быстрая сортировка:\n");
for (int i = 0; i < mas.Length; i++) mas[i] = rand.Next(count);
//sort.Print(mas);
stpWatch5.Start();
sort.QuickSort(mas, 0, mas.Length - 1);
stpWatch5.Stop();
Console.WriteLine("Quick Sort StopWatch: " + (stpWatch5.ElapsedMilliseconds / 1000.0).ToString());
//sort.Print(mas);
sort.QuickSortReverse(mas, 0, mas.Length - 1);
//sort.Print(mas);

Console.WriteLine("Группировка Четные и нечетные числа:\n");
for (int i = 0; i < mas.Length; i++) mas[i] = rand.Next(count);
//sort.Print(mas);
mas=sort.EvenOddNumber(mas);
//sort.Print(mas);
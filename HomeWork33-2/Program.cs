

using HomeWork33_2;
Sort sort = new Sort();

int[] mas = new int[100];
Random rand = new Random();
for (int i = 0; i < mas.Length; i++) mas[i] = rand.Next(1, 100);
sort.Print(mas);
Console.WriteLine("Пузырьковая сортировка:\n");
sort.BubbleSort(mas);
sort.Print(mas);
sort.BubbleSortReverse(mas);
sort.Print(mas);
Console.WriteLine("Сортировка выбором:\n");
for (int i = 0; i < mas.Length; i++) mas[i] = rand.Next(1, 100);
sort.Print(mas);
sort.SelectionSort(mas);
sort.Print(mas);
sort.SelectionSortReverse(mas);
sort.Print(mas);
Console.WriteLine("Сортировка вставкой:\n");
for (int i = 0; i < mas.Length; i++) mas[i] = rand.Next(1, 100);
sort.Print(mas);
sort.InsertionSort(mas);
sort.Print(mas);
sort.InsertionSortReverse(mas);
sort.Print(mas);


Console.WriteLine("Быстрая сортировка:\n");
for (int i = 0; i < mas.Length; i++) mas[i] = rand.Next(1, 100);
sort.Print(mas);
sort.QuickSort(mas,0,mas.Length-1);
sort.Print(mas);
sort.QuickSortReverse(mas, 0, mas.Length-1);
sort.Print(mas);

//sort.SelectionSort(mas);
//sort.InsertionSort(mas);
//sort.MergeSort(mas, 0, mas.Length - 1);
//sort.QuickSort(mas, 0, mas.Length - 1);


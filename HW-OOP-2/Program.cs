using HW_OOP_2;

Console.WriteLine("Введите необходимое значение элементов массива");
int n;
int.TryParse(Console.ReadLine(), out n);
DinamicArray array = new DinamicArray(n);
Console.WriteLine("Заполненный случайными числами массив:");
array.masRandom();
array.masPrint();
Console.WriteLine();
Console.WriteLine("Перемешанный массив:");
array.masRandomChange();
array.masPrint();
Console.WriteLine();
array.masCount();
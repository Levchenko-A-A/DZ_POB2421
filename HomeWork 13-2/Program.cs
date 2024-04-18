//1.Написать программу, которая будет генерировать случайные числа от
//1 до 10 и выводить их на экран до тех пор, пока не будет сгенерировано
//число 7.

Console.WriteLine("Задача 1");
int number = 0;
do
{
    Random random = new Random();
    number = random.Next(1, 11);
    Console.Write($"{number} ");
}
while (number != 7);

//2.Написать программу, которая будет запрашивать у пользователя
//числа, пока он не введет число 0. После этого программа должна
//вывести сумму всех введенных пользователем чисел.

Console.WriteLine("Задача 2");
double summ = 0, temp = 0;
do
{
    Console.Write("Введите число: ");
    temp = double.Parse(Console.ReadLine()!); 
    summ += temp;
}
while (temp != 0);
Console.WriteLine($"Сумма всех чисел: {summ}");

Random random = new Random();
int number1 = random.Next(1,6);
int i = 1;
Console.WriteLine("Компьютер загадал число от 1 до 5.\nУ Вас 3 попытки угадать.");
while (i<=3)
{
    Console.Write($"Введите число. Попытка N{i++}: ");
    int number2=int.Parse( Console.ReadLine()!);
    if (number2 == number1)
    {
        Console.WriteLine("Вы угали!!!");
        break;
    }
    else Console.WriteLine("Вы не угадали.");
}
Console.WriteLine($"Компьютер загадал {number1}");

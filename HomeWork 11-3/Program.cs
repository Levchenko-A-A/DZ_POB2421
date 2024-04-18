//1.Сгенерировать случайное целое число в диапазоне от 0 до 5, запросить
//еще одно число у пользователя и в случае совпадения вывести на экран
//информацию о победе, в противном случае - поражении.

Random random = new Random();
int numberOne = random.Next(0, 5 + 1);
Console.Write("Введите целое число: ");
int numberTwo = int.Parse(Console.ReadLine()!);
if (numberTwo == numberOne) Console.WriteLine($"Вы угадали. Компьютер загадал {numberOne}");
else Console.WriteLine($"Вы не угадали. Компьютер загадал {numberOne}");



//Random random = new Random();
//int n=random.Next(120);
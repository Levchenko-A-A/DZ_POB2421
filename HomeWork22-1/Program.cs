
//Исключительная ситуации или исключение (exception) – это возникновение в программе непредвиденного события, 
//которое может порождаться некорректным использованием аппаратуры или неправильной работой программы.

//Примеры.

//Обработка исключений при попытки деления на ноль
//try
//{
//    Console.Write("Введите первое число:");
//    int n = int.Parse(Console.ReadLine()!);
//    Console.Write("Введите второе число:");
//    int m = int.Parse(Console.ReadLine()!);
//    Console.WriteLine(n / m);
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine(e.Message);
//}

//Обработка исключений попытки передать в метод аргумент неверного формата (при вводе с клавиатуры символа, выводиться сообщение)
//try
//{
//    Console.Write("Введите число:");
//    int n = int.Parse(Console.ReadLine()!);

//}
//catch (FormatException e)
//{
//    Console.WriteLine(e.Message);
//}

//Обработка исключений при ошибке преобразования типа
//try
//{
//    object obj = "you";
//    int num = (int)obj;
//    Console.WriteLine($"Результат: {num}");
//}
//catch (InvalidCastException e)
//{
//    Console.WriteLine(e.Message);
//}

//Обработка исключений если индекс массива выходит за пределы диапазона
//try
//{
//    int[] mas = new int[5];
//    Console.WriteLine(mas[7]);
//}
//catch (IndexOutOfRangeException e)
//{ 
//    Console.WriteLine(e.Message);
//}

//Обработка исключений, возникающих при доступе к данным с помощью потоков, файлов и каталогов.
//FileInfo info = new FileInfo("text.txt");
//try
//{
//    info.Open(FileMode.Open);

//}
//catch (IOException e)
//{
//    Console.WriteLine(e.Message);
//}

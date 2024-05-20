//Задача 1:
//Напишите программу, которая принимает от пользователя строку,
//содержащую числа, разделенные запятой. Используя метод Split(),
//разделите строку на отдельные числа и найдите их сумму. Выведите
//полученную сумму на экран.

//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//string[] mas = str.Split(' ');
//double summ = 0;
//foreach (string strNumber in mas)
//{
//    bool isNumber = true;
//    for (int i = 0; i < strNumber.Length; i++)
//    {
//        if (!char.IsDigit(strNumber[i]) && strNumber[i] != ',' && strNumber[i] != '.')
//        {
//            isNumber = false;
//            break;
//        }
//    }
//    if (isNumber && !strNumber.Contains('.') && !strNumber.Contains(','))
//    {
//        Console.WriteLine(int.Parse(strNumber));
//        summ += double.Parse(strNumber);
//    }
//    else
//    if (isNumber && (strNumber.Contains('.') || strNumber.Contains(',')))
//    {
//        if (strNumber.Contains('.'))
//        {
//            string temp = strNumber.Replace('.', ',');
//            Console.WriteLine(double.Parse(temp));
//            summ += double.Parse(temp);
//        }
//        else
//        {
//            Console.WriteLine(double.Parse(strNumber));
//            summ += double.Parse(strNumber);
//        }
//    }
    
//}
//Console.WriteLine($"Сумма введенных значений: {summ:F2}");
//Console.ReadLine();

//Задача 2:
//Напишите программу, которая запрашивает у пользователя
//предложение и определяет, сколько слов в нем содержатся. Для этого
//используйте метод Split() для разделения предложения на отдельные
//слова и подсчитайте их количество. Выведите полученное число на
//экран.

//Console.Write("Введите строку:");
//string str = Console.ReadLine()!;
//string[] mas = str.Split(' ', StringSplitOptions.RemoveEmptyEntries); //StringSplitOptions.RemoveEmptyEntries - удаляем лишние пробелы.
//foreach (string i in mas) Console.WriteLine(i);
//Console.WriteLine($"Колличество слов в строке: {mas.Length}");

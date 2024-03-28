using static System.Console;
//
//WriteLine("Press any key combination: ");
//ConsoleKeyInfo key = ReadKey();
//WriteLine();
//WriteLine("Key: {0}, Char: {1}, Modifiers: {2}", arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);

//if (args.Length<3)
//{
//    WriteLine("You must specify two colors and cursor size, e.g.");
//    WriteLine("dotnet run red yellow 50");
//    return;
//}
//ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[0], ignoreCase: true);
//BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[1], ignoreCase: true);
//CursorSize = int.Parse(args[2]);

//int a = int.Parse(ReadLine()!);
//int b = int.Parse(ReadLine()!);
//WriteLine(a % b);

//Определение НОК
//int n1, n2, LCM = 0;
//Write("Введите два целых числа: ");
//string[] arr = ReadLine().Split();
//n1= int.Parse(arr[0]);
//n2= int.Parse(arr[1]);
//LCM = (n1>n2)? n2 : n1;
//while (true)
//{ 
//    if(LCM%n1==0&&LCM%n2==0)
//    {
//        WriteLine($"НОК = {LCM}");
//        break;
//    }
//    ++LCM;
//}

//Вычисляем обратное число
//int n, reversNubber = 0, remainder;
//Write("Введите число: ");
//n = Convert.ToInt32(ReadLine());
//while (n!=0)
//{
//    remainder = n % 10;
//    reversNubber=reversNubber*10+remainder;
//    n /= 10;
//}
//WriteLine($"Обратное число = {reversNubber}");




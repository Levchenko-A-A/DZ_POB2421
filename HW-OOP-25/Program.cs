//Console.Write("Введите число:");
//double x = double.Parse(Console.ReadLine());
//if (x >= 0) Console.WriteLine(x);
//else Console.WriteLine(-x);
//Console.WriteLine((x >= 0) ? x : -x);

//1. Проверить, является ли число четным или нечетным, используя 
//тернарный оператор.

//Console.Write("Введите число:");
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine((x % 2 == 0) ? "Четное" : "Нечетное");

//2.Написать программу, которая запрашивает у пользователя его 
//возраст и выводит сообщение "Совершеннолетний" или 
//"Несовершеннолетний", используя тернарный оператор. 
//Console.Write("Введите возраст:");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine((age >= 18) ? "Совершеннолетний" : "Несовершеннолетний");

//3.Написать программу, которая запрашивает у пользователя число и проверяет, является ли оно положительным, отрицательным или 
//равным нулю, используя тернарный оператор. 

//Console.Write("Введите число:");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine((n > 0) ? "Положительное" : (n < 0) ? "Отрицательное" : "Равно нулю");

//4.Написать программу, которая запрашивает у пользователя два 
//числа и выводит на экран наибольшее из них, используя 
//тернарный оператор. 

//Console.Write("Введите 1 число:");
//int n1 = int.Parse(Console.ReadLine());
//Console.Write("Введите 2 число:");
//int n2 = int.Parse(Console.ReadLine());
//Console.WriteLine((n1 > n2) ? $"{n1}>{n2}" : (n1 < n2) ?
//    $"{n1}<{n2}" : $"{n1}={n2}");

//5.Написать программу, которая запрашивает у пользователя три 
//числа и выводит на экран наименьшее из них, используя 
//тернарный оператор.
//Console.Write("Введите 1 число:");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите 2 число:");
//int b = int.Parse(Console.ReadLine());
//Console.Write("Введите 3 число:");
//int c = int.Parse(Console.ReadLine());
//Console.WriteLine((a < b && b < c) ? $"{a}" : (b < a && a < c) ? $"{b}" : $"{c}");

//5.Написать программу, которая запрашивает у пользователя свой 
//рост и вес, а затем выводит на экран сообщение о том, имеет ли он лишний вес, нормальный вес или недостаточный вес.

//Console.Write("Введите рост:");
//double rost = double.Parse(Console.ReadLine());
//Console.Write("Введите массу:");
//double massa = double.Parse(Console.ReadLine());
//if (rost - 100 > massa) Console.WriteLine("Недостаточный вес");
//else if (rost - 100 < massa) Console.WriteLine("Лишний вес");
//else Console.WriteLine("Нормальный вес");

//6.Написать программу, которая запрашивает у пользователя номер 
//месяца и выводит на экран сообщение о том, какое время года 
//соответствует этому месяцу. 

//Console.WriteLine("Введите номер месяца:");
//int n=int.Parse(Console.ReadLine());
//if (n == 12 || n == 1 || n == 2)
//    Console.WriteLine("Зима");
//else if (n == 3 || n == 4 || n == 5)
//    Console.WriteLine("Весна");
//else if (n == 6 || n == 7 || n == 8)
//    Console.WriteLine("Лето");
//else if ((n == 9 || n == 10 || n == 11)) 
//    Console.WriteLine("Осень");
//else Console.WriteLine("Нет такого месяца");

//7.Известны площади круга и квадрата. 
//Определить: 
//а) уместится ли круг в квадрате? 
//б) уместится ли квадрат в круге? 
//Console.Write("Введите площадь круга:");
//double s1 = double.Parse(Console.ReadLine());
//Console.Write("Введите площадь квадрата:");
//double s2 = double.Parse(Console.ReadLine());
//double R=Math.Sqrt(s1/Math.PI);
//double a=Math.Sqrt(s2);
//if (2 * R <= a) Console.WriteLine("круг уместится в квадрате");
//else Console.WriteLine("круг не уместится в квадрате");
//if (2*a*a <= 4*R*R) Console.WriteLine("квадрат уместится в круге");
//else Console.WriteLine("квадрат не уместится в круге");

//double s1 = 0;
//int greate10 = 0;
//int less10 = 0;
//int max = int.MinValue;
//int min = int.MaxValue;
//Console.Write("Введите число 1:");
//int a1=int.Parse(Console.ReadLine());
//s1 += a1;
//if (a1 > 10) greate10++;
//if (a1 < 10) less10++;
//if(a1>max) max=a1;
//if (a1 < min) min = a1;   
//Console.Write("Введите число 2:");
//int a2 = int.Parse(Console.ReadLine());
//s1 += a2;
//if (a2 > 10) greate10++;
//if (a2 < 10) less10++;
//if (a2 > max) max = a1;
//if (a2 < min) min = a1;

//Random random = new Random();
////генерация целочисленных типов
//int n=random.Next(100);//0..99
//Console.WriteLine(n);
//int m=random.Next(-10,20);//-10..19
//Console.WriteLine(m);
////генерация вещественных чисел
//double x=random.NextDouble();//0..1
//Console.WriteLine($"{x:F2}");
//double y = random.NextDouble()*20;//0..20
//Console.WriteLine($"{y:F2}");

//1.Напишите программу, которая запрашивает у пользователя год его рождения и выводит на экран сообщение о том, является ли этот год високосным или нет. 
//Console.Write("Введите ваш год рождения:");
//int year=int.Parse(Console.ReadLine());
//if (year % 4 == 0) Console.WriteLine("високосный");
//else Console.WriteLine("не високосный");
//Console.WriteLine((year % 4 == 0) ? "високосный" : "не високосный");

//Random random = new Random();
//int n=random.Next(120);
//Console.WriteLine(n);
//if (n >= 10 && n <= 100) Console.WriteLine("Лежит в диапазоне от 10 до 100");
//else Console.WriteLine("Не лежит в диапазоне от 10 до 100");

//5.Напишите программу, которая генерирует случайное число от 1 до 10, а затем запрашивает у пользователя угадать это число.
//Если  пользователь угадывает число, программа выводит сообщение о победе. Если нет, программа выводит сообщение о том,
//было ли введено число больше или меньше загаданного.

//Random random = new Random();
//int n = random.Next(1, 11);
//Console.Write("Введите число:");
//int m=int.Parse(Console.ReadLine());
//if (n == m) Console.WriteLine("Победа");
//else Console.WriteLine((n > m) ? "Загаданное число больше":
//    "Загаданное число меньше");

//6
//Console.Write("Введите ваш возраст:");
//int age=int.Parse(Console.ReadLine());
//Console.Write("Введите ваш рост в сантиметрах:");
//double rost = double.Parse(Console.ReadLine());
//Console.Write("Введите ваш вес:");
//double weight = double.Parse(Console.ReadLine());
//double rostm = rost / 100;
//double imt = weight / (rostm * rostm);
//if (age < 65)
//{

//    if (imt < 18.5) Console.WriteLine("Недостаточный вес");
//    else if (imt >= 18.5 && imt <= 24.9) Console.WriteLine("Нормальный вес");
//    else if (imt >= 25 && imt <= 29.9) Console.WriteLine("Избыточный вес");
//    else Console.WriteLine("Ожирение");
//}
//else if (age >= 65 && age <= 74)
//{

//    if (imt < 22) Console.WriteLine("Недостаточный вес");
//    else if (imt >= 22 && imt <= 26.9) Console.WriteLine("Нормальный вес");
//    else if (imt >= 27 && imt <= 29.9) Console.WriteLine("Избыточный вес");
//    else Console.WriteLine("Ожирение");
//}
//else
//{
//    if (imt <=23) Console.WriteLine("Недостаточный вес");
//    else if (imt > 23 && imt <= 27.9) Console.WriteLine("Нормальный вес");
//    else if (imt >= 28 && imt <= 29.9) Console.WriteLine("Избыточный вес");
//    else Console.WriteLine("Ожирение");
//}

//1.Напишите программу, которая генерирует случайный цвет
//(например, красный, зеленый или синий) и выводит его на экран.
//Затем программа запрашивает у пользователя угадать этот цвет.
//Если пользователь угадывает цвет, программа выводит сообщение
//о победе. Если нет, программа выводит сообщение о том, был ли
//введен цвет раньше или позже загаданного. 
//Random random = new Random();
//int color = random.Next(3);
//string textColor = "";
//if (color == 0) textColor = "Красный";
//else if (color == 1) textColor = "Зеленый";
//else if (color == 2) textColor = "Cиний";
//string myColor = Console.ReadLine();
//int myColorInt = -1;
//if (myColor == "Красный") myColorInt = 0;
//else if (myColor == "Зеленый") myColorInt = 1;
//else myColorInt = 2;
//if (color == myColorInt) Console.WriteLine("Победа");
//else if (color < myColorInt) Console.WriteLine("Раньше");
//else Console.WriteLine("Позже");

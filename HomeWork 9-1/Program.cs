//1.Произведите операцию логического умножения со следующими
//числами:
//8х3
//22х4

Console.WriteLine("Задача 1-1");
int value1 = 8;
int value2 = 3;
string binary1= Convert.ToString(value1,2);
string binary2= Convert.ToString(value2,2);
Console.WriteLine($"DEC: {value1,6}\n" +
                  $"DEC: {value2,6}\n" +
                  $"BIN: {binary1,6}\n" +
                  $"BIN: {binary2,6}\n" +
                  $"Результат &:\n" +
                  $"DEC: {value1&value2,6}\n" +
                  $"BIN: {Convert.ToString(value1&value2,2),6}\n");

Console.WriteLine("Задача 1-2");
value1 = 22;
value2 = 4;
binary1 = Convert.ToString(value1, 2);
binary2 = Convert.ToString(value2, 2);
Console.WriteLine($"DEC: {value1,6}\n" +
                  $"DEC: {value2,6}\n" +
                  $"BIN: {binary1,6}\n" +
                  $"BIN: {binary2,6}\n" +
                  $"Результат &:\n" +
                  $"DEC: {value1 & value2,6}\n" +
                  $"BIN: {Convert.ToString(value1 & value2, 2),6}\n");

//2.Произведите операцию логического сложения со следующими
//числами:
//65,29;
//44,12;

Console.WriteLine("Задача 2-1");
value1 = 65;
value2 = 29;
binary1 = Convert.ToString(value1, 2);
binary2 = Convert.ToString(value2, 2);
Console.WriteLine($"DEC: {value1,7}\n" +
                  $"DEC: {value2,7}\n" +
                  $"BIN: {binary1,7}\n" +
                  $"BIN: {binary2,7}\n" +
                  $"Результат |:\n" +
                  $"DEC: {value1 | value2,7}\n" +
                  $"BIN: {Convert.ToString(value1 | value2, 2),7}\n");

Console.WriteLine("Задача 2-2");
value1 = 44;
value2 = 12;
binary1 = Convert.ToString(value1, 2);
binary2 = Convert.ToString(value2, 2);
Console.WriteLine($"DEC: {value1,7}\n" +
                  $"DEC: {value2,7}\n" +
                  $"BIN: {binary1,7}\n" +
                  $"BIN: {binary2,7}\n" +
                  $"Результат |:\n" +
                  $"DEC: {value1 | value2,7}\n" +
                  $"BIN: {Convert.ToString(value1 | value2, 2),7}\n");

//3.Произведите операцию логического исключения со
//следующими числами, разберитесь с возможностью шифрования
//чисел:
//249, (ключ)8;
//Проработать это тщательно!

Console.WriteLine("Задача 3");
value1 = 249;
int key = 8;
value2 = value1^key;
binary1 = Convert.ToString(value1, 2);
binary2 = Convert.ToString(key, 2);
Console.WriteLine($"DEC: {value1,8}\n" +
                  $"DEC: {key,8}\n" +
                  $"BIN: {binary1,8}\n" +
                  $"BIN: {binary2,8}\n" +
                  $"Результат 249^8:\n" +
                  $"DEC: {value1 ^ key,8}\n" +
                  $"BIN: {Convert.ToString(value1 ^ key, 2),8}\n" +
                  $"Обратное исключение:\n" +
                  $"DEC: {value2 ^ key,8}\n" +
                  $"BIN: {Convert.ToString(value2 ^ key, 2),8}\n");
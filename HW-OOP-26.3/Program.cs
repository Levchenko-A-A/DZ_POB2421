//Thread thread = new Thread(CountTo100);
//thread.Start();
//for(int i = 0; i < 100; i++)
//{
//    Console.SetCursorPosition(30,i);
//    Console.WriteLine($"Основной поток: {i}");
//    Thread.Sleep(1000);
//}
//thread.Interrupt();
//Console.WriteLine("Оба потока завешили работу.");

//static void CountTo100()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Thread.Sleep(1000);
//        Console.WriteLine($"Второстепенный поток: {i}");
//    }
//}

//Thread thread = new Thread(ShowMessage);
//thread.Start("Привет");

//static void ShowMessage(object? messege)
//{
//    Console.WriteLine(messege);
//}
//---------------------------------------------------------------------------------
//Thread firstThread = new Thread(new ParameterizedThreadStart(ShowMessage));
//Thread secondThread = new Thread(ShowMessage);
//Thread thirdThread = new Thread(message => Console.WriteLine(message));

//firstThread.Start("Строка");
//secondThread.Start(25);
//thirdThread.Start(true);

//static void ShowMessage(object? messege)
//{
//    Console.WriteLine(messege);
//}
//---------------------------------------------------------------------------------
//Thread firstThread = new Thread(new ParameterizedThreadStart(ShowMessage));
//Thread secondThread = new Thread(ShowMessage);
//Thread thirdThread = new Thread(message => Console.WriteLine(message));

//firstThread.Start("Строка");
//secondThread.Start(25);
//thirdThread.Start(true);
//static void ShowMessage(object? messege)
//{
//    if(messege is string)
//        Console.WriteLine($"Строка: {messege}");
//    else if (messege is int)
//        Console.WriteLine($"Число: {messege}");
//    else if (messege is bool)
//        Console.WriteLine($"Логический тип: {messege}");
//    else Console.WriteLine($"Неизвестный тип");
//}
//--------------------------------------------------------------------------------
//using HW_OOP_26._3;
//Thread firstThread = new Thread(Print);
//Thread secondThread = new Thread(Print);
//firstThread.Start(new Person());
//secondThread.Start("Строка");

//static void Print(object? message)
//{
//    if(message is not Person)
//    {
//        throw new Exception("Передан не подходящий объект");
//    }
//    else
//    {
//        PrintPersonData((Person)message);
//    }
//}
//static void PrintPersonData(Person person)
//{
//    person.Name = "Виктор";
//    person.Age = 22;
//    Console.WriteLine($"Имя: {person.Name}\nВозраст: {person.Age}");
//}
//-------------------------------------------------------------------------------
using HW_OOP_26._3;
Thread firstThread = new Thread(Print);
Thread secondThread = new Thread(Print);
firstThread.Start(new Person());
secondThread.Start("Строка");

static void PrintValue(CustomArray array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10);
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
static void Print(object? message)
{
    if (message is Person)
    {
        PrintPersonData((Person)message);
    }
    else if (message is CustomArray)
    {
        PrintValue((CustomArray)message);
    }
    else
    {
        throw new Exception("Передан не подходящий объект");
    }
}
static void PrintPersonData(Person person)
{
    person.Name = "Виктор";
    person.Age = 22;
    Console.WriteLine($"Имя: {person.Name}\nВозраст: {person.Age}");
}
class CustomArray
{
    private double[] data;
    public int Length {  get {  return data.Length; } }
    public double this[int index]
    { 
        get { return data[index]; }
        set { data[index] = value; }
    }
    public CustomArray(int length)
    {
        data = new double[length];
    }
}

//DZ1
//MathOper Sum = delegate (int first, int second)
//{
//    return first + second;
//};
//Console.WriteLine(Sum(40, 90));
//MathOper Summ = (int first, int second) => first + second;
//Console.WriteLine(Summ(40, 90));
//var Summm = (int first, int second) => first + second;
//Console.WriteLine(Summm(40, 90));
//delegate double MathOper(int first, int second);


//DZ2
//using System.ComponentModel.Design;

//List<string> list = new List<string>();
//View Print = delegate (string[] mas)
//{
//    foreach (string item in mas)
//        Console.WriteLine(item);
//};
//string[] FindFirst(string[] mas, Predicate<string> func)
//{
//    List<string> result = new List<string>();
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (func(mas[i])) result.Add(mas[i]); ;
//    }
//    return result.ToArray();
//}
//string[] mas = new string[10]
//    {"adljnblsfnv",
//     "bpwri;dnfsa",
//     "apdnkbklfvbsv",
//     "xpdinbpidnbr",
//     "apldnbodnb",
//     "Apdintbpdintbpidb",
//     "bpeotjpegrr",
//     "e;dkntbpsng",
//     "lpenpngpwrngv",
//     "apidngttbpdnb" };
//Print(mas);
//Console.WriteLine();
//foreach (string i in FindFirst(mas, x => x.ToLower().IndexOf("a") == 0))
//{
//    list.Add(i);
//    Console.WriteLine(i);
//}
//Console.WriteLine();
//foreach(string item in list)
//    Console.WriteLine(item);
//delegate void View(string[] mas);

//DZ3
Calculator[] operations = new Calculator[]
    {
        Add,
        Sub,
        Mul,
        Div
    };
Console.Write("Введите первое число: ");
int first = 0;
int.TryParse(Console.ReadLine(), out first);
Console.Write("Введите второе число: ");
int second = 0;
int.TryParse(Console.ReadLine(), out second);
Console.Write("Введите операцию: ");
string? operation = Console.ReadLine();
switch(operation)
{
    case "+": operations[0](first,second); break;
    case "-": operations[1](first, second); break;
    case "*": operations[2](first, second); break;
    case "/": operations[3](first, second); break;
    default:
        Console.WriteLine("Некорректный ввод."); break;
}

void Add(int x, int y)
{
    Console.WriteLine(x + y);
};
void Sub(int x, int y)
{
    Console.WriteLine(x - y);
};
void Mul(int x, int y)
{
    Console.WriteLine(x * y);
};
void Div(int x, int y)
{
    if (y == 0) Console.WriteLine("Делить на ноль нельзя");
    else Console.WriteLine(x * y);
};
delegate void Calculator(int x, int y);
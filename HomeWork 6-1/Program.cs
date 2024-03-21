using System.Linq.Expressions;

Console.Write("Введите число:");
string textVar = Console.ReadLine();
byte textVar_byte = Convert.ToByte(textVar);
Console.WriteLine(textVar_byte);
nint textVar_nint = Convert.ToInt32(textVar_byte);
Console.WriteLine(textVar_nint);
int textVar_int = Convert.ToInt(textVar_nint);


Console.ReadLine();
using System.Linq.Expressions;

Console.Write("Введите число:");
string textVar = Console.ReadLine();                        //Ввод целочисленной переменной
byte textVar_byte = Convert.ToByte(textVar);                //Конвертация строковой переменной в переменную типа byte
Console.WriteLine(textVar_byte);
nint textVar_nint = Convert.ToInt32(textVar_byte);          //Конвертация типа byte в тип nint
Console.WriteLine(textVar_nint);
int textVar_int = Convert.ToInt32(textVar_nint);            //Конвертация типа nint в тип int
Console.WriteLine(textVar_int);
long textVar_long = Convert.ToInt64(textVar_int);           //Конвертация типа int в тип long
Console.WriteLine(textVar_long);
double textVar_Double = Convert.ToDouble(textVar_long);     //Конвертация типа long в тип double
Console.WriteLine(textVar_Double);

//Console.ReadLine();
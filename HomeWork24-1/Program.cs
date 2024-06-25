string s;
s = Console.ReadLine()!;
if (Polindrom(s))
    Console.WriteLine("Введенное слово является полиндромом");
else
    Console.WriteLine("Введенное слово не является полиндромом");


bool Polindrom(String s)
{
    char firstSymbol;
    char lastSymbol;
    int size = s.Length;
    String subString;
    if (size <= 1)
        return true;
    else
    {
        firstSymbol = s[0];
        lastSymbol = s[size - 1];
        subString = s.Substring(1, size - 2);
        return firstSymbol == lastSymbol && Polindrom(subString);
    }
}
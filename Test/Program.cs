﻿
string str = Console.ReadLine();
Console.WriteLine(str);
Console.WriteLine(PerevodX(str));


int PerevodX(string temp)
{
    int result = 0;
    if (temp == "A") result = 0;
    else if (temp == "Б") result = 1;
    else if (temp == "В") result = 2;
    else if (temp == "Г") result = 3;
    else if (temp == "Д") result = 4;
    else if (temp == "Е") result = 5;
    else if (temp == "Ж") result = 6;
    else if (temp == "З") result = 7;
    else if (temp == "И") result = 8;
    else if (temp == "К") result = 9;
    return result;
}
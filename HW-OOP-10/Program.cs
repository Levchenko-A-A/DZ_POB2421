using HW_OOP_10;
using System.ComponentModel;

NumberClass firstNumber = new NumberClass { FirstNumber = 12345 };
Console.WriteLine("Цифра по индексу 2 в базовом классе: " + firstNumber[4]);
SecondClass secondNumber = new SecondClass { FirstNumber = 12345, SecondNumber = 6789 };
Console.WriteLine("Цифра по индексу (0, 1) в производном классе: " + secondNumber[0, 1]);
Console.WriteLine("Цифра по индексу (1, 2) в производном классе: " + secondNumber[1, 2]);

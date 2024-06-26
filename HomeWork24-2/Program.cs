using System;

Console.Write("Введите число:");
int a;
int.TryParse(Console.ReadLine(), out a);
OutOddNumber(a - 1);

void OutOddNumber(int n)
{
    try
    {

        if (n > 0)
        {

            if (n % 2 == 1)
            {

                OutOddNumber(n - 1);
                Console.WriteLine(n);
            }
            else
            {
                OutOddNumber(n - 1);
            }


        }
        else return;
    }
    catch (StackOverflowException e)
    {
        Console.WriteLine(e.Message);
    }
}
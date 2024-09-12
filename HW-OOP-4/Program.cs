using HW_OOP_4;

MasIndex masIndexOne = new MasIndex(5);
MasIndex masIndexTwo = new MasIndex(5);
MasIndex masIndexThird = new MasIndex(masIndexOne.lengMas+masIndexTwo.lengMas);
masIndexOne.Fill();
masIndexTwo.Fill();
masIndexThird.Fill();
Console.WriteLine("Вывод на экран первого массива:");
for (int i = 0; i < masIndexOne.lengMas; i++)
    Console.WriteLine(masIndexOne[i]);
Console.WriteLine("Вывод на экран второго массива:");
for (int i = 0; i < masIndexTwo.lengMas; i++)
    Console.WriteLine(masIndexTwo[i]);
masIndexThird =masIndexOne.Merge(masIndexOne, masIndexTwo);
Console.WriteLine("Вывод на экран объединенного третьево массива:");
for (int i = 0; i < masIndexThird.lengMas; i++)
    Console.WriteLine(masIndexThird[i]);
Console.WriteLine();
masIndexThird = masIndexOne.MasDistinc(masIndexThird);
Console.WriteLine("Вывод на экран третьево массива без дубликатов:");
for (int i = 0; i < masIndexThird.lengMas; i++)
    Console.WriteLine(masIndexThird[i]);
Console.WriteLine("Нажмите любую клавишу.");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Вывод на экран первого массива:");
for (int i = 0; i < masIndexOne.lengMas; i++)
    Console.WriteLine(masIndexOne[i]);
Console.WriteLine("Какую строку вывести на экран отдельно?:");
int n;
int.TryParse(Console.ReadLine()!, out n);
Console.WriteLine(masIndexOne[n - 1]);
Console.ReadLine();
Console.WriteLine("Нажмите любую клавишу.");
using HomeWork33;
Operations operations = new Operations();

operations.Print();
//operations.RemoveAtIndex();
//operations.Print();

Console.Write("Введите название запись для поиска:");
string name = Console.ReadLine()!;
if (operations.FindIndex(name)>=0)
    Console.WriteLine(operations.FindIndex(name));
else 
    Console.WriteLine("Введеное значение не найдено!!!");

operations.FindList(name);

operations.Print();
operations.SortList();
operations.Print();
operations.Clear();
operations.Print();
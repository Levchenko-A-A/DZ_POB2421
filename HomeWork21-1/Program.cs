Console.Write("Введите путь к папке:");
string path = Console.ReadLine()!;
Console.Write("Введите название файла:");
string fileName = Console.ReadLine()!;
if (!File.Exists(path + fileName))
    {
        File.Create(path + fileName);
        Console.WriteLine("Файл не был найден и создан");
    }
else Console.WriteLine("Файл найден");
Console.Write("Введите текст:");
string textFoFile = Console.ReadLine()!;
File.WriteAllTextAsync(path + fileName, textFoFile);
Console.WriteLine("Файл успешно записан.");
Console.WriteLine("Содержимое аписанного файла:");
Console.WriteLine(await File.ReadAllTextAsync(path + fileName));

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
FileInfo fileInfo = new FileInfo(path + fileName);
Console.WriteLine($"Размер файла: {fileInfo.Length} байт");
Console.WriteLine($"Дата последнего изменения: {fileInfo.LastWriteTime}");
Console.WriteLine($"Расширение файла: {fileInfo.Extension}");


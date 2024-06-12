string dirName = Directory.GetCurrentDirectory();
Console.Clear();

do
{
    DirectoryInfo dirInfo = new DirectoryInfo(dirName);
    Console.Clear();
    Console.WriteLine($"Текущая директория: {dirInfo.FullName}");
    Console.WriteLine("Подкаталоги:");
    DirectoryInfo[] dirs = dirInfo.GetDirectories();
    foreach (DirectoryInfo dir in dirs)
    {
        Console.WriteLine(dir.Name);
    }
    Console.WriteLine();
    Console.WriteLine("Файлы:");
    FileInfo[] files = dirInfo.GetFiles();
    foreach (FileInfo file in files)
    {
        Console.WriteLine(file.Name);
    }
    Console.WriteLine("Введите название папки для перехода (или 'выход' для завершения):");
    string choice = Console.ReadLine()!;
    if (choice == "выход") break;
    else if (choice != "выход")
    {
        dirInfo.CreateSubdirectory(choice);
        dirName += "\\";
        dirName += choice;
    }    
}
while (true);

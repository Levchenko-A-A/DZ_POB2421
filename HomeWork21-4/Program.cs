Console.Write("Введите путь к папке:");
string sourcePath = Console.ReadLine()!;
DirectoryInfo dirInfo = new DirectoryInfo(sourcePath);
if (dirInfo.Exists) Console.WriteLine("Папка найдена");
Console.WriteLine();
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
Console.WriteLine();
Console.Write("Вы хотите удалить Паку или Файл, Выход?:");
string name = Console.ReadLine()!;
switch(name)
{
    case "Папку": 
        {
            string str2 = "";
            do
            {
                Console.Write("Вы действительно хотите удалить каталог (да, нет)?:");
                str2=Console.ReadLine()!;
                if (str2 == "да")
                {
                    dirInfo.Delete(true);
                    Console.WriteLine("Каталог удален.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Каталог не удален.");
                    Console.ReadKey();
                    break;
                }
                
            } while (true);
        }
        break;
    case "Файл": 
        {
            Console.Write("Ведите название файла:");
            string fileName = Console.ReadLine()!;
            FileInfo fileInfo = new FileInfo(sourcePath+"/"+fileName);
            if (fileInfo.Exists)
            {
                string str2 = "";
                do
                {
                    Console.WriteLine("Файл найден");
                    Console.WriteLine("Удалить файл? д/н:");
                    str2 = Console.ReadLine()!;
                    if (str2 == "д" || str2 == "н") break;
                    Console.Clear();
                }
                while (true);
                if (str2 == "д") fileInfo.Delete();
                Console.WriteLine("Файл удален");
                Console.ReadKey();
            }
            else Console.WriteLine($"Файл не найден");
        }
        break;
    case "Выход": break;
}


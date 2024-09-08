using HomeWork33;
Console.WriteLine("Вам необходимо ввести три значения (строки):");
Operations operations = new Operations();
bool flag=true; 
do
{
    Console.Clear();
    operations.Print();
    Console.WriteLine("Меню:\n" +
                      "1. Добавить еще 3 поля.\n" +
                      "2. Удалить элемент из списка по индексу.\n" +
                      "3. Поиск записи по значению.\n" +
                      "4. Очистить список.\n" +
                      "5. Сортировка списка.\n" +
                      "6. Поиск всех вхождений\n" +
                      "7. Сохранение списка в файл.\n" +
                      "8. Загрузить список из файл\n" +
                      "9. Выход.");
    int n = 0;
    Console.Write("Ваш выбор:");
    int.TryParse(Console.ReadLine(), out n);
    switch(n)
    {
        case 1:
            {
                Console.Clear();
                operations.Print();
                operations.AddString();
            }
            break;
        case 2:
            {
                operations.RemoveAtIndex();
            }
            break;
        case 3:
            {
                Console.Clear();
                operations.Print();
                Console.Write("Введите значение записи для поиска:");
                string name=Console.ReadLine()!;
                operations.FindList(name);
            }
            break;
        case 4:
            {
                operations.Clear();
            }
            break;
        case 5:
            {
                Console.Clear();
                operations.Print();
                operations.SortList();
                operations.Print();
            }
            break;
        case 6:
            {
                Console.Clear();
                operations.Print();
                Console.Write("Введите значение записи для поиска:");
                string name = Console.ReadLine()!;
                operations.FindAllValues(name);
            }
            break;
        case 7:
            {
                Console.Clear();
                Console.Write("Введите путь к файлу:");
                string path=Console.ReadLine()!;
                Console.Write("Введите имя файла:");
                string nameFile = Console.ReadLine()!;
                operations.SaveToFile(path+nameFile);
            }
            break;
        case 8:
            {

                Console.Clear();
                Console.Write("Введите путь к файлу:");
                string path = Console.ReadLine()!;
                Console.Write("Введите имя файла:");
                string nameFile = Console.ReadLine()!;
                operations.LoadToFile(path + nameFile);
            }
            break;
        case 9:
            {
                flag=false;
            }
            break;
    }
    Console.Clear();
}
while (flag);
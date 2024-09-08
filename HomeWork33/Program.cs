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
                      "7. Операции с числами.\n" +
                      "8. Сохранение списка в файл.\n" +
                      "9. Загрузить список в файл\n" +
                      "10. Выход.");
    int n = 0;
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

            }
            break;
        case 6:
            {

            }
            break;
        case 7:
            {

            }
            break;
        case 8:
            {

            }
            break;
        case 9:
            {

            }
            break;
        case 10:
            {
                flag=false;
            }
            break;
    }
    Console.Clear();
}
while (flag);

//operations.AddString();
//operations.Print();
//operations.Print();
//operations.RemoveAtIndex();
//operations.Print();
//Console.Write("Введите название запись для поиска:");
//string name = Console.ReadLine()!;
//operations.FindList(name);
//operations.SortList();
//operations.Print();
//Console.Write("Введите название запись для поиска:");
//name = Console.ReadLine()!;
//operations.FindAllValues(name);
//operations.Clear();
//operations.Print();
using HomeWork33;
Console.WriteLine("Вам необходимо ввести три значения (строки):");
Operations operations = new Operations();
bool flag=true; 
do
{
    Console.WriteLine("Меню:\n" +
                      "1. Добавить еще 3 поля.\n" +
                      "2. Удалить элемент из саиска по индексу.\n" +
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

            }break;
        case 2:
            {

            }
            break;
        case 3:
            {

            }
            break;
        case 4:
            {

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
}
while (flag);

operations.AddString();
operations.Print();
//operations.RemoveAtIndex();
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
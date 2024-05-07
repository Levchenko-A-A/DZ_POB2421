int count = 0;
object[,] tasks = new Object[0, 0];
do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("1-Добавить задачу\n" +
                  "2-Удалить задачу\n" +
                  "3-Перезаписать задачу\n" +
                  "4-Вывести список задач\n" +
                  "5-Выход\n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Выберите пункт меню:");
    int n = int.Parse(Console.ReadLine()!);
    switch (n)
    {
        case 1:
            {
                count++;
                object[,] temp = new object[count, 4];
                Array.Copy(tasks, temp, tasks.Length);
                Console.Write("Введите название задачи:");
                temp[count - 1, 0] = Console.ReadLine()!;
                Console.Write("Введите дату задачи:");
                temp[count - 1, 1] = Console.ReadLine()!;
                Console.Write("Введите время исполнения:");
                temp[count - 1, 2] = Console.ReadLine()!;
                Console.Write("Введите приоритет задачи:");
                temp[count - 1, 3] = int.Parse(Console.ReadLine()!);
                tasks = new Object[count, 4];
                Array.Copy(temp, tasks, temp.Length);
            }
            break;
        case 2:
            {
                Console.Clear();
                Console.WriteLine("Имеющиеся задачи:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + tasks[i, 0] + " " + tasks[i, 1] + " " + tasks[i, 2] + " " + tasks[i, 3]);
                }
                Console.Write("Какую задачу удалить:");
                int k = int.Parse(Console.ReadLine());
                object[,] temp = new object[count - 1, 4];
                int size = 0;
                for (int i = 0; i < count; i++)
                {
                    if (i != k - 1)
                    {
                        temp[size, 0] = tasks[size, 0];
                        temp[size, 1] = tasks[size, 1];
                        temp[size, 2] = tasks[size, 2];
                        temp[size, 3] = tasks[size, 3];
                        size++;
                    }

                }
                count--;
                tasks = new Object[count, 4];
                Array.Copy(temp, tasks, tasks.Length);
            }
            break;
        case 3:
            {
                Console.Clear();
                Console.WriteLine("Имеющиеся задачи:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + tasks[i, 0] + " " + tasks[i, 1] + " " + tasks[i, 2] + " " + tasks[i, 3]);
                }
                Console.Write("Какую задачу редактировать:");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Введите новое название задачи:");
                tasks[b - 1, 0] = Console.ReadLine();
                Console.Write("Введите новую дату задачи:");
                tasks[b - 1, 1] = Console.ReadLine();
                Console.Write("Введите новое время задачи:");
                tasks[b - 1, 2] = Console.ReadLine();
                Console.Write("Введите новый приоритет задачи:");
                tasks[b - 1, 0] = Console.ReadLine();
            }
            break;
        case 4:
            {
                Console.Clear();
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + tasks[i, 0] + " " + tasks[i, 1] + " " + tasks[i, 2] + " " + tasks[i, 3]);
                }
                Console.ReadKey();
            }
            break;
        case 5: break;
        default: Console.WriteLine("Нет такого пункта меню."); break;
    }
    if (n == 5) break;

}
while (true);

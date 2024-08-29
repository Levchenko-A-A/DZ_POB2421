using HomeWork31_1;
using Microsoft.VisualBasic;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;
//Staff staffs = new Staff();

List<Staff> Assistans = new List<Staff>();
bool flag = true;

do
{
    Console.Clear();
    Console.WriteLine("Меню:\n" +
                      "1. Добавить нового сотрудника:\n" +
                      "2. Удаление сотрудника по Фамилии:\n" +
                      "3. Поиск сотрудника по имени или должности:\n" +
                      "4. Вывод списка всех сотрудников:\n" +
                      "5. Подсчет количества сотрудников в компании:\n" +
                      "6. Выход.");
    Console.WriteLine();
    Console.Write("Выберите пункт меню:");
    int n;
    int.TryParse(Console.ReadLine(), out n);
    switch (n)
    {
        case 1:
            {
                Console.Write("Введите Имя:");
                string name = Console.ReadLine()!;
                Console.Write("Введите Фамилию:");
                string surname = Console.ReadLine()!;
                Console.Write("Введите Должность:");
                string post = Console.ReadLine()!;
                Staff staffs = new Staff();
                staffs.Name = name;
                staffs.Surname = surname;
                staffs.Post = post;
                Assistans.Add(staffs);
            }
            break;
        case 2:
            {
                Console.Write("Введите Фамилию:");
                string surname = Console.ReadLine()!;
                Staff staff = Assistans.Find(x => x.Surname == surname);
                Assistans.Remove(staff);
            }
            break;
        case 3:
            {
                Console.WriteLine("1 - поиск по имени\n" +
                                  "2 - поиск по должности");
                Console.Write("Введите номер:");
                int m;
                int.TryParse(Console.ReadLine(), out m);
                switch (m)
                {
                    case 1:
                        {
                            Console.Write("Введите имя:");
                            string name = Console.ReadLine()!;
                            Staff staff = Assistans.Find(x => x.Name == name);
                            Console.WriteLine(staff.Name + " " + staff.Surname+" "+staff.Post);
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Введите телефон:");
                            string surnamee = Console.ReadLine()!;
                            Staff staff = Assistans.Find(x => x.Surname == surnamee);
                            Console.WriteLine(staff.Name + " " + staff.Surname + " " + staff.Post);
                            Console.ReadKey();
                        }
                        break;
                }
            }
            break;
        case 4:
            {
                Console.Clear();
                Console.WriteLine("Фамилия, Имя, Должность");
                foreach (Staff staff in Assistans)
                {
                    Console.WriteLine(staff.Name + " " + staff.Surname + " " + staff.Post);
                }
                Console.ReadKey();
            }
            break;
        case 5:
            {
                Console.WriteLine(Assistans.Count());
                Console.ReadKey();
            }
            break;
        case 6:
            {
                flag=false;
            }
            break;
    }
}
while (flag);
using HW_OOP_30._2;
using System.Xml.Serialization;

List<User> users = Serialization.DeserializeUsers();
bool flag1 = true;
bool flag2 = true;
while(flag1)
{
    Console.Clear();
    Console.WriteLine("Меню:\n" +
                      "1. Вход\n" +
                      "2. Регистрация\n" +
                      "3. Выход");
    Console.Write("Выш выбор:");
    int n;
    int.TryParse(Console.ReadLine(), out n);
    switch(n)
    {
        case 1:
            {
                Console.Write("Введите Имя:");
                string _name = Console.ReadLine()!;
                Console.Write("Введите пароль:");
                string _password = Console.ReadLine()!;
                if (UserManagement.AuthenticateUser(_name, _password, users))
                {
                    while (flag2)
                    {
                        Console.Clear();
                        Console.WriteLine("Меню:\n" +
                                          "1. Вывод списка пользователей\n" +
                                          "2. Редактирование пользователя\n" +
                                          "3. Удаление пользователя.\n" +
                                          "4. Выход");
                        Console.Write("Выш выбор:");
                        int m;
                        int.TryParse(Console.ReadLine(), out m);
                        switch (m)
                        {
                            case 1:
                                {
                                    UserManagement.PrintList(users);
                                }
                                break;
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
                                    flag2 = false;
                                }
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Такой пользователь не разегистрирован!!!");
                    Console.WriteLine("Нажмите любую клавишу и попробуете снова!!!");
                    Console.ReadKey();
                }
                
            }
            break;
        case 2:
            {
                User user = new User();
                Console.Write("Введите Имя:");
                string _name = Console.ReadLine()!;
                Console.Write("Введите возраст:");
                int _age;
                int.TryParse(Console.ReadLine(), out _age);
                Console.Write("Введите пароль:");
                string _password = Console.ReadLine()!;
                user.Name = _name;
                user.Age = _age;
                user.Password = _password;
                UserManagement.RegisterUser(user, users);
                Serialization.SerializeUsers(users);
            }
            break;
        case 3:
            {
                flag1 = false;
            }
            break;
    }
}
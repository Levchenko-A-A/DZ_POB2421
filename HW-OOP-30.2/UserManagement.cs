using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_30._2
{
    internal class UserManagement
    {
        public static void RegisterUser(User user, List<User> temp)
        {
            User targetUser = temp.Find(u => u.Name.ToLower() == user.Name.ToLower().ToString());
            if (targetUser != null)
            {
                Console.WriteLine($"Пользователь {user.Name} найден в списке! Попробуйте еще раз!!!");
                Console.WriteLine("Нажмите любую клавишу!!!");
                Console.ReadKey();
            }
            else
            {
                temp.Add(user);
            }
        }

        public static bool AuthenticateUser(string _name, string _password, List<User> temp)
        {
            User result = null;
            foreach (User user in temp)
            {
                if (user.Name == _name && user.Password == _password)
                {
                    result = user;
                }
            }
            if(result != null)
                return true;
            return false;
        }
        public static void PrintList(List<User> temp)
        {
            foreach (User user in temp) 
                Console.WriteLine(user.Name+" "+user.Age+" "+user.Name);
            Console.WriteLine("Нажмите любую клавишу!!!");
            Console.ReadKey();
        }
    }
}

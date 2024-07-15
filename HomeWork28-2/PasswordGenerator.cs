using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork28_2
{
    internal class PasswordGenerator
    {
        private string? login;
        private string? password;

        public PasswordGenerator(string? login, string? password)
        {
            this.login = login;
            this.password = password;
        }

        public PasswordGenerator()
        {
        }

        public string getLogin() => login!;
        public string getPassword() => password!;
        public void setLogin(string? login) => this.login = login;
        public void setPassword(string? password) => this.password = password;
        public string GenNewPassword()
        {
            Random random = new Random();
            string NewPassword = "";
            for (int i = 0; i < 8; i++)
            {
                int n = random.Next(1, 5);
                Console.WriteLine(n);
                switch (n)
                {
                    case 1: NewPassword += (char)random.Next(65, 91); break;
                    case 2: NewPassword += (char)random.Next(97, 122); break;
                    case 3: NewPassword += (char)random.Next(48, 57); break;
                    case 4: NewPassword += (char)random.Next(33, 38); break;
                    case 5: NewPassword += (char)random.Next(63, 64); break;

                }
            }
            return NewPassword;
        }
    }
}

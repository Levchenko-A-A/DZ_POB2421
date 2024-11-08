﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson17
{
    internal class UserAuthentification
    {
        private static bool isAuth;
        private string path = "user.json";
        public List<User> Users { get; set; } = new();
        public static User? RegisterUser { get; set; }

        public UserAuthentification()
        {
            getUsers();
        }

        public bool AuthentificationUser(string? name, string? password)
        {
            if (Users.Find(p => p.UserName == name && p.Password == Hash(password)) != null)
            {
                RegisterUser = Users.Find(p => p.UserName == name && p.Password == Hash(password));
                isAuth = true;
                return true;
            }
            return false;
        }
        public static bool IsUserAuthentification()
        {
            return isAuth;
        }

        public void getUsers()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                if (text != "")
                {
                    Users = JsonSerializer.Deserialize<List<User>>(text)!;
                }
            }
        }
        public static void ExitUser()
        {
            RegisterUser = null;
        }
        public string Hash(string text)
        {
            string res = "";
            for (int i = 0; i < text.Length; i++)
            {
                res += (int)(text[i] << 10);
            }
            return res;
        }
    }
}

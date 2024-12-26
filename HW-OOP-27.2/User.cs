﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_27._2
{
    internal class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Role { get; set; }
    }
}

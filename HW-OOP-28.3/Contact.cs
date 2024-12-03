using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_28._3
{
    internal class Contact
    {
        [DisplayName("Имя")]
        public string? FirstName { get; set; }
        [DisplayName("Фамилия")]
        public string? LastName { get; set; }
        [DisplayName("Отчество")]
        public string? Patronymic { get; set; }
        [DisplayName("Адрес")]
        public string? Adress { get; set; }
        [DisplayName("Номер телефона")]
        public string? PhoneNumber { get; set; }
        [DisplayName("Электронный адрес")]
        public string? Email { get; set; }

        public Contact(string? firstName, string? lastName, string? patronymic, string? adress, string? phoneNumber, string? email)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}

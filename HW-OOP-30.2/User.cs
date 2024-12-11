using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW_OOP_30._2
{
    [Serializable]
    public class User
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Password { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW_OOP_30._2
{
    class Serialization
    {
        public static void SerializeUsers(List<User> users)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (FileStream writer = new FileStream("users.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(writer, users);
                writer.Close();
            }
        }

        public static List<User> DeserializeUsers()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            List<User> users = new List<User>();
            FileInfo file = new FileInfo("users.xml");
            if (file.Exists)
            {
                using (FileStream reader = new FileStream("users.xml", FileMode.Open))
                {
                    users = (List<User>)serializer.Deserialize(reader);
                    reader.Close();
                }
            }
            else return users;
            return users;
        }
    }
}

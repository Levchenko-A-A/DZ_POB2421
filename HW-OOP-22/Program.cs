using System.Collections;

Console.Write("Введите UserName:");
string? userName = Console.ReadLine()!;
Console.Write("Введите UserLogin:");
string? userLogin = Console.ReadLine()!;
Console.Write("Введите Password:");
string? password = Console.ReadLine()!;
User newUser = new(userName, userLogin, password);
public class User: IUser
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }
    public User(string? name, string? login, string? password)
    {
        string[] userData;
        if (File.Exists("User.txt"))
            {
            userData = File.ReadAllLines("User.txt");
            for (int i = 0; i < userData.Length; i++)
            {
                if (userData[i].Split(" ")[2] == login)
                {
                    Console.WriteLine("Пользователь с таким логином существует");
                    return;
                }
            }
        }
        else userData = new string[0];
        Id = userData.Length;
        try
        {
            Name = new IsDataExists((data) => { if (string.IsNullOrEmpty(data)) { throw new Exception("Нет данных"); } return data; })(name!);
            Login = new IsDataExists((data) => { if (string.IsNullOrEmpty(data)) { throw new Exception("Нет данных"); } return data; })(login!);
            Password = new IsDataExists((data) => { if (string.IsNullOrEmpty(data)) { throw new Exception("Нет данных"); } return data; })(password!);
        }
        catch (Exception e) 
        {
            Console.WriteLine(e.Message);
        }
        SaveData($"{Id} {Name} {Login} {Password}");
    }
    private void SaveData(string dataLine)
    {
        string[] tempData;
        if (File.Exists("User.txt"))
            tempData = File.ReadAllLines("User.txt");
        else tempData = new string[0];
        List<string> data = new List<string>();
        data.AddRange(tempData);
        data.Add(dataLine);
        File.WriteAllLines("User.txt", data);
    }
}
internal interface IUser
{
    public int Id { set; }
    public string? Name { set; }
    public string? Login { set; }
    public string? Password { set; }
}
public delegate string IsDataExists(string data);
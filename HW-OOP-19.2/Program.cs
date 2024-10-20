using System.Collections;
using System.ComponentModel;

Task task1 = new("Задача 1", DateTime.Parse("10.12.2025"), Prioity.Low);
Task task2 = (Task)task1.Clone();
Task task3 = (Task)task1.Clone();
Task task4 = (Task)task1.Clone();
Task task5 = (Task)task1.Clone();
task2.Title = "Задача 2";
task2.DueDate = DateTime.Parse("10.10.2025");
task2.Prioity=Prioity.High;
task3.Title = "Задача 3";
task3.DueDate = DateTime.Parse("20.07.2025");
task3.Prioity = Prioity.Medium;
task4.Title = "Задача 4";
task4.DueDate = DateTime.Parse("22.12.2024");
task4.Prioity = Prioity.High;
task5.Title = "Задача 5";
task5.DueDate = DateTime.Parse("01.02.2025");
task5.Prioity = Prioity.Medium;

Console.WriteLine(task1);
Console.WriteLine(task2);
Console.WriteLine(task3);
Console.WriteLine(task4);
Console.WriteLine(task5);

Employee employee=new Employee("Иванов",1,employee.Add(new Task("Задача 1", DateTime.Parse("10.12.2025"), Prioity.Low));


enum Prioity
{
    Low,
    Medium,
    High
};
class Employee : ICloneable,IComparable, IEnumerable
{
    public string? Name { get; set; }
    private int id;
    public int Id
    {
        get { return id; }
        set { if (value > 0) id = value; }
    }
    public List<Task> Tasks { get; set; }
    public Employee(string? name, int id)
    {
        Name = name;
        Id = id;
        Tasks = new List<Task>();
    }
    public Employee(Employee employee)
    {
        Name=employee.Name;
        Id = employee.Id;
        Tasks = new List<Task>(employee.Tasks);
    }
    public void Add(Task task)
    {
        Tasks.Add(task);
    }
    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public override string? ToString()
    {
        return $"{id} {Name} {Tasks}";
    }

    public object Clone() => new Employee(this);    
}

class Task: ICloneable
{
    public string? Title { get; set; }
    public DateTime DueDate { get; set; }
    public Prioity Prioity { get; set; }

    public Task(string? title, DateTime dueDate, Prioity prioity)
    {
        Title = title;
        DueDate = dueDate;
        Prioity = prioity;
    }
    public Task(Task task)
    {  
        Title = task.Title; 
        DueDate = task.DueDate; 
        Prioity = task.Prioity;
    }
    public object Clone()=>new Task(this);

    public void Display()
    {
        Console.WriteLine(Title + " " + DueDate + " " + Prioity);
    }

    public override string? ToString()
    {
        return $"{Title} {DueDate} {Prioity}";
    }
}
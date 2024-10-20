using System.Collections;
using System.ComponentModel;

Task task1 = new("Задача 1", DateTime.Parse("10.12.2025"), Priority.Low);
Task task2 = (Task)task1.Clone();
Task task3 = (Task)task1.Clone();
Task task4 = (Task)task1.Clone();
Task task5 = (Task)task1.Clone();
task2.Title = "Задача 2";
task2.DueDate = DateTime.Parse("10.10.2025");
task2.Priority=Priority.High;
task3.Title = "Задача 3";
task3.DueDate = DateTime.Parse("20.07.2025");
task3.Priority = Priority.Medium;
task4.Title = "Задача 4";
task4.DueDate = DateTime.Parse("22.12.2024");
task4.Priority = Priority.High;
task5.Title = "Задача 5";
task5.DueDate = DateTime.Parse("01.02.2025");
task5.Priority = Priority.Medium;
List<Employee> employees = new List<Employee>();
employees.Add(new Employee("Иван Иванов", 1));
employees.Add(new Employee("Петр Петров", 2));
employees.Add(new Employee("Сергей Сергеев", 3));
employees[0].Tasks.Add(new Task("Задача 1", DateTime.Parse("10.10.2025"), Priority.High));
employees[0].Tasks.Add(new Task("Задача 2", DateTime.Parse("01.02.2025"), Priority.Medium));
employees[1].Tasks.Add(task4);
employees[2].Tasks.Add(task5);

for(int i = 0; i < employees.Count; i++)
{
    Console.Write($"{employees[i].Id}  ");
    Console.WriteLine(employees[i].Name);
    foreach(Task item in employees[i].Tasks)
        Console.WriteLine(item);
}

employees.Sort();
Console.WriteLine();
for (int i = 0; i < employees.Count; i++)
{
    Console.Write($"{employees[i].Id}  ");
    Console.WriteLine(employees[i].Name);
    foreach (Task item in employees[i].Tasks)
        Console.WriteLine(item);
}

enum Priority
{
    Low,
    Medium,
    High
};
class Employee : ICloneable, IComparable<Employee>, IEnumerable<Task>
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
        Name = employee.Name;
        Id = employee.Id;
        Tasks = new List<Task>(employee.Tasks);
    }
    public int CompareTo(Employee other)
    {
        int result = 0;

        if (Tasks.Count != other.Tasks.Count)
        {
            result = Tasks.Count.CompareTo(other.Tasks.Count);
        }
        else
        {
            foreach (Task task in Tasks)
            {
                Task otherTask = other.Tasks.Find(t => t.Title == task.Title);
                if (otherTask != null)
                {
                    result = task.Priority.CompareTo(otherTask.Priority);
                    if (result == 0)
                    {
                        result = Name.CompareTo(other.Name);
                    }
                    break;
                }
            }
        }

        return result;
    }

    public IEnumerator<Task> GetEnumerator()
    {
        return Tasks.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() => Tasks.GetEnumerator();

    //public void Print(Employee item)
    //{
    //    Console.WriteLine(item.Id);
    //    Console.WriteLine(item.Name);
    //    foreach (var task in item)
    //    {
    //        Console.WriteLine(task);
    //    }
    //}

    public override string? ToString()
    {
        return $"{id} {Name} {Tasks.ToString()}";
    }

    public object Clone() => new Employee(this);    
}

class Task: ICloneable
{
    public string? Title { get; set; }
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; }

    public Task(string? title, DateTime dueDate, Priority prioity)
    {
        Title = title;
        DueDate = dueDate;
        Priority = prioity;
    }
    public Task(Task task)
    {  
        Title = task.Title; 
        DueDate = task.DueDate; 
        Priority = task.Priority;
    }
    public object Clone()=>new Task(this);
    public override string? ToString()
    {
        return $"{Title} {DueDate} {Priority}";
    }
}
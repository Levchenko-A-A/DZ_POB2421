﻿TaskManager taskManager = new TaskManager();
taskManager.Add(new Task()
{
    DueDate = DateTime.Parse("12.02.2024"),
    Prioity = Prioity.Medium,
    Title = "t1"
});
taskManager.Add(new Event()
{
    DueDate = DateTime.Parse("09.10.2024"),
    Location = "Konig",
    Prioity = Prioity.High,
    Title = "t2"
});
taskManager.Add(new Event()
{
    DueDate = DateTime.Parse("15.11.2024"),
    Location = "Anapa",
    Prioity = Prioity.Low,
    Title = "t3"
});
taskManager.Add(new Task()
{
    DueDate = DateTime.Parse("26.05.2025"),
    Prioity = Prioity.High,
    Title = "t4"
});

taskManager.Print();
taskManager.Remove(taskManager.Tasks[1]);
Console.WriteLine();
taskManager.Print();

Console.WriteLine("Какую запись необходимо изменить?:");
int n = int.Parse(Console.ReadLine()!);
taskManager.ChangeTaskOrEvent(taskManager.Tasks[n-1]);
taskManager.Print();

enum Prioity
{
    Low,
    Medium,
    High
};

class Task : ITask
{
    public string? Title { get; set; }
    public DateTime DueDate { get; set; }
    public Prioity Prioity { get; set; }

    public void Display()
    {
        Console.WriteLine(Title + " " + DueDate + " " + Prioity);
    }
}

class Event : ITask
{
    public string? Title { get; set; }
    public string? Location { get; set; }
    public DateTime DueDate { get; set; }
    public Prioity Prioity { get; set; }

    public void Display()
    {
        Console.WriteLine(Title + " " + DueDate + " " + Prioity + " " + Location);
    }
}
class TaskManager
{
    public List<ITask> Tasks { get; set; } = new();

    public void Add(ITask task)
    {
        Tasks.Add(task);
    }
    public void Remove(ITask task)
    {
        Tasks.Remove(task);
    }
    public void Print()
    {
        int j = 1;
        foreach (var item in Tasks)
        {
            Console.Write(j++ + " ");
            item.Display();
        }
    }
    public void ChangeTaskOrEvent(ITask task)
    {
        if (task is Task)
        {
            task.Display();
            Console.Write("Введите новое название задачи:");
            string str = Console.ReadLine()!;
            task.Title = str;
            Console.Write("Введите новую дату:");
            DateTime temtDate = DateTime.Parse(Console.ReadLine()!);
            task.DueDate = temtDate;
            Console.Write("Введите новsq приоритет задачи (Low, Medium, High):");
            str = Console.ReadLine()!;
            if (Enum.IsDefined(typeof(Prioity), str))
                task.Prioity = (Prioity)Enum.Parse(typeof(Prioity), str, true);
            else
                Console.WriteLine("Значение приоритета введено не верно.");
        }
        else if (task is Event)
        {
            task.Display();
            Console.Write("Введите новое название задачи:");
            string str = Console.ReadLine()!;
            task.Title = str;
            Console.Write("Введите новую дату:");
            DateTime temtDate = DateTime.Parse(Console.ReadLine()!);
            task.DueDate = temtDate;
            Console.Write("Введите новsq приоритет задачи (Low, Medium, High):");
            str = Console.ReadLine()!;
            if (Enum.IsDefined(typeof(Prioity), str))
                task.Prioity = (Prioity)Enum.Parse(typeof(Prioity), str, true);
            else
                Console.WriteLine("Значение приоритета введено не верно.");
            Console.Write("Введите новое локацию задачи:");
            str = Console.ReadLine()!;
            (Event)task.Location = str;
        }
    }

}
interface ITask
{
    string Title { get; set; }
    DateTime DueDate { get; set; }
    Prioity Prioity { get; set; }
    void Display();
}
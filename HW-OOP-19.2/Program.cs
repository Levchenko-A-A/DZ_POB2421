enum Prioity
{
    Low,
    Medium,
    High
};
class Employee
{
    public string? Name { get; set; }
    private int id;
    public int Id 
    {  
        get { return id; } 
        set { if (value > 0) id = value; } 
    }   
     
}

class Task: ICloneable
{
    public string? Title { get; set; }
    public DateTime DueDate { get; set; }
    public Prioity Prioity { get; set; }

    public object Clone()
    {
        throw new NotImplementedException();
    }

    public void Display()
    {
        Console.WriteLine(Title + " " + DueDate + " " + Prioity);
    }

    public override string? ToString()
    {
        return $"{"Task"},{Title},{DueDate},{Prioity}";
    }
}
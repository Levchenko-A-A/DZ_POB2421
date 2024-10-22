using Microsoft.VisualBasic;
List<Animal> list = new List<Animal>();
list.Add(new Animal(1, "Черныш", "чихуахуа", DateTime.Parse("10.10.2021"), 5));
list.Add(new Animal(2, "Кнопка", "шпиц", DateTime.Parse("21.04.2022"), 4));
list.Add(new Animal(3, "Чипа", "хаски", DateTime.Parse("18.01.2017"), 8));
Animals<Animal> catalog = new Animals<Animal>(list);
catalog.AddAnimal(new Animal(4, "Белка", "такса", DateTime.Parse("27.10.2021"), 5));
foreach (Animal a in catalog.GetAnimal())
{
    Console.WriteLine(a.Id+" "+a.Name+" "+a.Breed+" "+a.AcceptanceDate+" "+a.Age);
}

interface IListAnimal<T>
{
    T Id { get; }
}

class Animal: IListAnimal<int>
{
    public int Id { get; }
    public string? Name { get; set; }
    public string? Breed { get; set; }
    public DateTime? AcceptanceDate { get; set; }
    public int Age { get; set; }

    public Animal(int id, string? name, string? breed, DateTime? acceptanceDate, int age)
    {
        Id = id;
        Name = name;
        Breed = breed;
        AcceptanceDate = acceptanceDate;
        Age = age;
    }

}
class Animals<T> where T: IListAnimal<int>
{
    private List<T> list = new List<T>();

    public Animals(List<T>? l)
    {
        list.AddRange(l!);
    }
    public void AddAnimal(T animal) => list!.Add(animal);
    public List<T> GetAnimal() => list!; 
    public T GetConcreteAnimal(int id) => list![id];
    
}
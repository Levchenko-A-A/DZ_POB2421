using CsvHelper;
using CsvHelper.Configuration;
using HW_OOP_29._1;
using System;
using System.Globalization;

List<Person> list = new List<Person>()
{
new Person { Name = "John" , Age = 30 },
new Person { Name = "Alice" , Age = 25 }
};
CsvConfiguration csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    Delimiter = ";"
};
using (StreamWriter writer = new StreamWriter("output.csv"))
{
    
    CsvWriter csvWrite = new CsvWriter(writer, csvConfig); 
    list.Add(new Person() { Name = "Ivan", Age = 23 });
    list.Add(new Person() { Name = "Sergei", Age = 19 });
    list.Add(new Person() { Name = "Mike", Age = 23 });
    list.Add(new Person() { Name = "Ivan", Age = 23 });
    csvWrite.WriteRecords(list);
    writer.Close();
}
List<Person> records;
using (StreamReader reader = new StreamReader("output.csv"))
{
    CsvReader csvRead = new CsvReader(reader, csvConfig);
    records = csvRead.GetRecords<Person>().ToList();
    reader.Close();
}
foreach(Person tmp in list)
{
    Console.WriteLine($"Имя: {tmp.Name}\nВозраст: {tmp.Age}");
}
Console.WriteLine();
foreach (Person person in records)
{
    Console.WriteLine($"Имя: {person.Name}\nВозраст: {person.Age}");
}

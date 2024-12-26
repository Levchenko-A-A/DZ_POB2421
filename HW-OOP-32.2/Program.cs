using CsvHelper.Configuration;
using CsvHelper;
using HW_OOP_32._2;
using System.Globalization;

using (IrisContext db = new IrisContext())
{
    StreamReader reader = new StreamReader("iris.csv");
    CsvReader csvReader = new CsvReader(reader,
    new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ",",
        HasHeaderRecord = true,
        HeaderValidated = null
    });
    List<IrisLoad> records = csvReader.GetRecords<IrisLoad>().ToList();
    foreach (var record in records)
    {
        Iris iris = new Iris()
        {
            Variety = record.Variety,
            SepalWidth = record.SepalWidth,
            Petallength = record.PetalLength,
            PetalWidth = record.PetalWidth,
            Sepallength = record.SepalLength
        };
        db.Iris.Add(iris);
    }
    db.SaveChanges();
    reader.Close();
}
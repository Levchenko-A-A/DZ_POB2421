using System.Collections;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

Library Books = new Library();
Books.BookAdd(new Book("qwertyu","Ivanov","Povest",1957));
Books.BookAdd(new Book("sdsfgfg", "Petrov", "Poema", 1983));
Books.BookAdd(new Book("nvjvjv", "Sidorov", "Novella", 1882));

foreach (Library book in Books)
{
    Console.WriteLine(book);
}
string textJson = Books.SerializeBooksToJson(Books.GetBooks());
Library.SaveToFile("Booksjson.json", textJson);
string textFromJson = Library.ReadToFile("Booksjson.json");
Console.WriteLine(textFromJson);

List<Book> Books2 = Books.DeserializeBooksFromJsonFromFile(textFromJson)!;
foreach (var book in Books2)
{
    Books.BookAdd(book);
}
foreach (var book in Books2)
{
    Console.WriteLine(book.Title + " " + book.Author + " " + book.Genre + " " + book.Year);
}




class Library: IEnumerable
{
    List<Book> books { get; set; } = new();
    public Library()
    {
    }

    public void BookAdd(Book book)=>books.Add(book);
    public List<Book> GetBooks() => books;
    public static void SaveToFile(string filename, string text)
    {
        using (StreamWriter writer = new StreamWriter(filename, false))
        {
            writer.WriteLineAsync(text);
        }
    }
    public static string ReadToFile(string filename)
    {
        string text;
        using (StreamReader reader = new StreamReader(filename))
        {
            text = reader.ReadToEnd();
        }
        return text;
    }
    public string SerializeBooksToJson(List<Book> books)
    {
        string? json=JsonSerializer.Serialize(books);
        return json;
    }
    public List<Book> DeserializeBooksFromJsonFromFile(string text)
    {
        return JsonSerializer.Deserialize<List<Book>>(text)!;
    }

    public IEnumerator GetEnumerator() => books.GetEnumerator();
}

class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Genre { get; set; }
    private int year;

    public Book(string? title, string? author, string? genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }

    public int Year 
    {
        get { return year; }
        set { if (value > 0) year = value; } 
    }

    public override string? ToString()
    {
        return $"{Title} {Author} {Genre} {Year}";
    }
}

using System;
using System.Collections;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

Library Books = new Library();
Books.BookAdd(new Book("qwertyu","Ivanov","Povest",1957));
Books.BookAdd(new Book("sdsfgfg", "Petrov", "Poema", 1983));
Books.BookAdd(new Book("nvjvjv", "Sidorov", "Novella", 1882));
foreach (var book in Books)
{
    Console.WriteLine(book);
}
string textJson = Books.SerializeBooksToJson(Books);
Library.SaveToFile("Booksjson.json", textJson);
string textFromJson = Library.ReadFromFile("Booksjson.json");
Console.WriteLine(textFromJson);
List<Book> Books2 = Books.DeserializeBooksFromJson(textFromJson)!;
foreach (var book in Books2)
{
    Console.WriteLine(book);
}
class Library: IEnumerable, IEnumerator
{
    List<Book> books { get; set; } = new();
    int index = -1;
    public Library()
    {
    }

    public void BookAdd(Book book)=>books.Add(book);
    public static void SaveToFile(string filename, string text)
    {
        if (File.Exists(filename))
        {
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                writer.WriteLineAsync(text);
                Console.WriteLine("Фаил записан");
            }
        }
        else Console.WriteLine("Файл не найден");
    }
    public static string ReadFromFile(string filename)
    {
        string text;
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                text = reader.ReadToEnd();
                Console.WriteLine("Файл прочитан.");
            }
            return text;
        }
        else return "Null";
    }
    public string SerializeBooksToJson(Library books)
    {
        string? json=JsonSerializer.Serialize(books);
        return json;
    }
    public List<Book> DeserializeBooksFromJson(string text)
    {
        return JsonSerializer.Deserialize<List<Book>>(text)!;
    }
    public IEnumerator GetEnumerator()
    {
        return this;
    }
    public bool MoveNext()
    {
        if (index == books.Count - 1)
        {
            Reset();
            return false;
        }

        index++;
        return true;
    }
    public void Reset()
    {
        index = -1;
    }
    public object Current
    {
        get
        {
            return books[index];
        }
    }
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

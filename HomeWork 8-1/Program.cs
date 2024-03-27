//В школьной библиотеке дети получают книги.
//Петя взял 10 книг, Алеша – на 4 книги меньше, чем Петя, а Ваня
//на 2 книги больше чем Алеша.
//Сколько книг взял каждый мальчик?
//Сколько книг они взяли вместе?

int books = 0;
int summ = 0;
books += 10;
summ += books;
Console.WriteLine($"Петя взял {books} книг.");
books -= 4;
summ += books;
Console.WriteLine($"Алеша взял {books} книг.");
books += 2;
summ += books;
Console.WriteLine($"Алеша взял {books} книг.");
Console.WriteLine($"Вместе ребята взяли {summ} книг.");
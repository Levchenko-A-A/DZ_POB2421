//В школьной библиотеке дети получают книги.
//Петя взял 10 книг, Алеша – на 4 книги меньше, чем Петя, а Ваня
//на 2 книги больше чем Алеша.
//Сколько книг взял каждый мальчик?
//Сколько книг они взяли вместе?

Console.WriteLine("\nЗадача номер 1\n");
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

//В первой корзине 23 яблока, а во второй на 11 яблок меньше.
//Сколько яблок в обеих корзинах?

Console.WriteLine("\nЗадача номер 2\n");
int firstBasket = 23;
int secondBasket = firstBasket - 11;
Console.WriteLine($"В двух корзинах {firstBasket+secondBasket} яблок.");
//Мама купила 1 десяток яиц и еще 3 яйца. Когда съели несколько
//яиц, то осталось 9 яиц. Сколько яиц съели?

Console.WriteLine("\nЗадача номер 1\n");
int basketBefore = 10;
basketBefore += 3;
Console.WriteLine($"Мама купила {basketBefore} яиц.");
int countEggs = 9;
Console.WriteLine($"Яиц съели {basketBefore - countEggs}.");

//Журнал имеет ширину 25см. Он уже газеты на 16см. Какой
//ширины газета?

Console.WriteLine("\nЗадача номер 2\n");
int journalWidth = 25;
int newspaperWidth = journalWidth + 16;
Console.WriteLine($"Ширина газеты {newspaperWidth}");

//Для приготовления обеда повару понадобилось 44 кг картошки,
//свеклы в 4 раза меньше, а лука в 2 раза меньше чем свеклы.
//Сколько килограмм лука потратил повар?

Console.WriteLine("\nЗадача номер 3\n");
double vegetables = 44;
Console.WriteLine($"Картошки для супа понадобилось {vegetables} кг.");
vegetables /= 4;
Console.WriteLine($"Свеклы для супа понадобилось {vegetables} кг.");
vegetables /= 2;
Console.WriteLine($"А лука повар потратил для супа {vegetables} кг.");

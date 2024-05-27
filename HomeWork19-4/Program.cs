Random random = new Random();
Random random2 = new Random();
char[,] mas1 = new char[10, 10];
char[,] mas2 = new char[10, 10];
string[] mas3 = { " N", "А", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И", "К" };
string[] mas4 = { " N", " 1", " 2", " 3", " 4", " 5", " 6", " 7", " 8", " 9", "10" };
for (int i = 0; i < mas1.GetLength(0); i++)
{
    for (int j = 0; j < mas1.GetLength(1); j++)
    {
        mas1[i, j] = '*';
        mas2[i, j] = '*';
    }
}
char[,] poleOne = new char[10, 10];
char[,] poleTwo = new char[10, 10];
for (int i = 0; i < poleOne.GetLength(0); i++)
{
    for (int j = 0; j < poleOne.GetLength(1); j++)
    {
        poleOne[i, j] = '-';
        poleTwo[i, j] = '-';
    }
}
FillTheShip4(poleOne); //заполнение 4-х палубным кораблем
FillTheShip3(poleOne); //заполнение 3-х палубными кораблями
FillTheShip2(poleOne); //Заполнение 2-х палубными кораблями
FillTheShip1(poleOne); //Заполнение 1-о палубными кораблями

string formPole = "*";
do
{
    Console.WriteLine("Компьютер сформировал свое поле.");
    Console.Write("Ваше поле сформировать автоматически или в ручную? (авт/руч):");
    formPole = Console.ReadLine()!;
    if (formPole == "авт" || formPole == "Авт" || formPole == "авт." || formPole == "Авт." ||
        formPole == "руч" || formPole == "Руч" || formPole == "руч." || formPole == "Руч.") break;
    Console.Clear();
}
while (true);
if (formPole == "авт" || formPole == "Авт" || formPole == "авт." || formPole == "Авт.")
{
    FillTheShip4(poleTwo); //заполнение 4-х палубным кораблем
    FillTheShip3(poleTwo); //заполнение 3-х палубными кораблями
    FillTheShip2(poleTwo); //Заполнение 2-х палубными кораблями
    FillTheShip1(poleTwo); //Заполнение 1-о палубными кораблями
    Console.WriteLine("Ваше поле:");
    PrintPole(poleTwo);
}
else if (formPole == "руч" || formPole == "Руч" || formPole == "руч." || formPole == "Руч.")
{
    int h1 = 4;
    for (int k = 1; k <= 4; k++)
    {
        for (int h = h1; h > 0; h--)
        {
            Console.Clear();
            PrintPole(poleTwo);
            Console.Write($"Укажите координату {k}-х палубного коробля и направление(A,1,гор):");
            string temp = Console.ReadLine()!;
            string[] mas = temp.Split(',');
            for (int i = 0; i < k; i++)
            {
                if (mas[2] == "гор")
                {
                    poleTwo[int.Parse(mas[1])-1, PerevodX(mas[0]) + i] = '#';
                }
                else if (mas[2] == "вер")
                {
                    poleTwo[int.Parse(mas[1]) - 1 + i, PerevodX(mas[0])] = '#';
                }
            }
        }
        h1--;
    }
    Console.Clear();
    Console.WriteLine("Ваше поле:\n");
    PrintPole(poleTwo);
}
string formPlay = "*";
do
{
    Console.WriteLine("Режим игры? (авт/руч.):");
    formPlay = Console.ReadLine()!;
    if (formPlay == "авт" || formPlay == "Авт" || formPlay == "авт." || formPlay == "Авт." ||
        formPlay == "руч" || formPlay == "Руч" || formPlay == "руч." || formPlay == "Руч.")
        break;
    Console.Clear();
}
while (true);
if (formPlay == "авт" || formPlay == "Авт" || formPlay == "авт." || formPlay == "Авт.")
{
    int count1 = 0;
    int count2 = 0;
    do
    {
        Console.Clear();
        PrintPole(mas1);
        Console.WriteLine($"Количество попаданий: {count1}");
        PrintPole(mas2);
        Console.WriteLine($"Количество попаданий: {count2}");
        int countInsert = 0;
        do
        {
            int a = random.Next(0, 10);
            int b = random.Next(0, 10);
            if (mas1[a, b] == '*')
            {
                mas1[a, b] = 'o';
                countInsert++;

                if (poleTwo[a, b] == '#')
                {
                    countInsert = 0;
                    mas1[a, b] = 'X';
                    count1++;
                }
                Thread.Sleep(100);
            }
        }
        while (countInsert == 0);
        if (count1 == 20) break;
        int countInsert2 = 0;
        do
        {
            int a2 = random.Next(0, 10);
            int b2 = random.Next(0, 10);
            if (mas2[a2, b2] == '*')
            {
                mas2[a2, b2] = 'o';
                countInsert2++;
                if (poleOne[a2, b2] == '#' && mas2[a2, b2] == 'o')
                {
                    countInsert2 = 0;
                    mas2[a2, b2] = 'X';
                    count2++;
                }
                Thread.Sleep(100);
            }
        } while (countInsert2 == 0);
        if (count1 >= 20 || count2 >= 20)
            break;
    }
    while (true);
    Console.Clear();
    PrintPole(mas1);
    PrintPole(mas2);
    if (count1 > count2) Console.WriteLine("Победил Компьютер.");
    else if (count1 < count2) Console.WriteLine("Победил Игрок.");
    Console.WriteLine("Игра закончена!!!");
    Console.WriteLine(count1);
    Console.WriteLine(count2);
}
else if (formPlay == "руч" || formPlay == "Руч" || formPlay == "руч." || formPlay == "Руч.")
{
    int count1 = 0;
    int count2 = 0;
    do
    {
        Console.Clear();
        PrintPole(mas1);
        Console.WriteLine($"Количество попаданий: {count1}");
        PrintPole(mas2);
        Console.WriteLine($"Количество попаданий: {count2}");
        int countInsert = 0;
        do
        {
            int a = random.Next(0, 10);
            int b = random.Next(0, 10);
            if (mas1[a, b] == '*')
            {
                mas1[a, b] = 'o';
                countInsert++;

                if (poleTwo[a, b] == '#')
                {
                    countInsert = 0;
                    mas1[a, b] = 'X';
                    count1++;
                }
                Thread.Sleep(200);
            }
        }
        while (countInsert == 0);
        if (count1 == 20) break;
        int countInsert2 = 0;
        do
        {
            Console.Write($"Укажите координату (A,1):");
            string temp = Console.ReadLine()!;
            string[] mas = temp.Split(',');
            mas2[int.Parse(mas[1]) - 1, PerevodX(mas[0])] = 'o';
            countInsert2++;
            if (poleOne[int.Parse(mas[1]) - 1, PerevodX(mas[0])] == '#' && mas1[int.Parse(mas[1]) - 1, PerevodX(mas[0])] == 'o')
            {
                Console.WriteLine("Вы попали, еще одна попытка.");
                countInsert2 = 0;
                mas2[int.Parse(mas[1]) - 1, PerevodX(mas[0])] = 'X';
                count2++;
            }
            Thread.Sleep(200);
        } while (countInsert2 == 0);
        if (count1 >= 20 || count2 >= 20)
            break;
    }
    while (true);
    Console.Clear();
    PrintPole(mas1);
    Console.WriteLine($"Количество попаданий: {count1}");
    PrintPole(mas2);
    Console.WriteLine($"Количество попаданий: {count2}");
    Console.WriteLine();
    if (count1 > count2) Console.WriteLine("Победил Компьютер.");
    else if (count1 > count2) Console.WriteLine("Победил Игрок.");
    Console.WriteLine("Игра закончена!!!");
    Console.WriteLine(count1);
    Console.WriteLine(count2);
}

void PrintPole (char[,] temp)
{
    Console.WriteLine();
    for (int i = 0; i < mas3.Length; i++)
        Console.Write(mas3[i] + " ");
    Console.WriteLine();
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        Console.Write(mas4[i + 1] + " ");
        for (int j = 0; j < temp.GetLength(1); j++)
        {
            Console.Write(temp[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillTheShip4(char[,] temp)
{
    do
    {
        Random rand1 = new Random();
        Random rand2 = new Random();
        Random rand3 = new Random();
        int a = rand1.Next(1, 9);
        int b = rand2.Next(1, 9);
        int c = rand3.Next(0, 1);
        if (c == 1)
        {
            if (b <= 5)
            {
                for (int i = 0; i < 4; i++)
                    temp[a, b + i] = '#';
                break;
            }
        }
        else if (c == 0)
        {
            if (a <= 5)
            {
                for (int i = 0; i < 4; i++)
                    temp[a + i, b] = '#';
                break;
            }
        }
    }
    while (true);
}
void FillTheShip3(char[,] temp)
{
    for (int k = 0; k < 2; k++)
    {
        Random rand1 = new Random();
        Random rand2 = new Random();
        Random rand3 = new Random();
        do
        {
            int a = rand1.Next(1, 9);
            int b = rand2.Next(1, 6);
            int c = rand3.Next(0, 1);
            if (c == 0)
            {
                if (temp[a, b] != '#' &&         temp[a, b + 1] != '#' &&     temp[a, b + 2] != '#' &&
                    temp[a - 1, b] != '#' &&     temp[a - 1, b + 1] != '#' && temp[a - 1, b + 2] != '#' &&
                    temp[a + 1, b] != '#' &&     temp[a + 1, b + 1] != '#' && temp[a + 1, b + 2] != '#' &&
                    temp[a - 1, b - 1] != '#' && temp[a + 1, b - 1] != '#' &&
                    temp[a - 1, b + 3] != '#' && temp[a + 1, b + 3] != '#' &&
                    temp[a, b - 1] != '#' &&     temp[a, b + 3] != '#')
                {
                    temp[a, b] = '#';
                    temp[a, b + 1] = '#';
                    temp[a, b + 2] = '#';
                    break;
                }
            }
            else if (c == 1)
            {
                if (temp[b, a] != '#' &&         temp[b + 1, a] != '#' &&     temp[b + 2, a] != '#' &&
                    temp[b - 1, a] != '#' &&     temp[b - 1, a + 1] != '#' && temp[b - 1, a + 2] != '#' &&
                    temp[b + 1, a] != '#' &&     temp[b + 1, a + 1] != '#' && temp[b + 1, a + 2] != '#' &&
                    temp[b - 1, a - 1] != '#' && temp[b - 1, a + 1] != '#' &&
                    temp[b + 3, a - 1] != '#' && temp[b + 3, a + 1] != '#' &&
                    temp[b - 1, a] != '#' &&     temp[b + 3, a] != '#')
                {
                    temp[b, a] = '#';
                    temp[b, a + 1] = '#';
                    temp[b, a + 2] = '#';
                    break;
                }
            }
        }
        while (true);
    }
}
void FillTheShip2(char[,] temp)
{
    for (int k = 0; k < 3; k++)
    {
        Random rand1 = new Random();
        Random rand2 = new Random();
        Random rand3 = new Random();
        do
        {
            int a = rand1.Next(1, 9);
            int b = rand2.Next(1, 6);
            int c = rand3.Next(0, 1);
            if (c == 0)
            {
                if (temp[a, b] != '#' &&         temp[a, b + 1] != '#' &&
                    temp[a - 1, b] != '#' &&     temp[a - 1, b + 1] != '#' &&
                    temp[a + 1, b] != '#' &&     temp[a + 1, b + 1] != '#' &&
                    temp[a - 1, b - 1] != '#' && temp[a + 1, b - 1] != '#' &&
                    temp[a - 1, b + 2] != '#' && temp[a + 1, b + 2] != '#' &&
                    temp[a, b - 1] != '#' &&     temp[a, b + 2] != '#')
                {
                    temp[a, b] = '#';
                    temp[a, b + 1] = '#';
                    break;
                }
            }
            else if (c == 1)
            {
                if (temp[b, a] != '#' &&         temp[b + 1, a] != '#' &&
                    temp[b - 1, a] != '#' &&     temp[b - 1, a + 1] != '#' &&
                    temp[b + 1, a] != '#' &&     temp[b + 1, a + 1] != '#' &&
                    temp[b - 1, a - 1] != '#' && temp[b - 1, a + 1] != '#' &&
                    temp[b + 2, a - 1] != '#' && temp[b + 2, a + 1] != '#' &&
                    temp[b - 1, a] != '#' &&     temp[b + 2, a] != '#')
                {
                    temp[b, a] = '#';
                    temp[b, a + 1] = '#';
                    break;
                }
            }
        }
        while (true);
    }
}
void FillTheShip1(char[,] temp)
{
    for (int k = 0; k < 4; k++)
    {
        Random rand1 = new Random();
        Random rand2 = new Random();
        do
        {
            int a = rand1.Next(1, 9);
            int b = rand2.Next(1, 9);
            if (temp[a, b] != '#' &&     temp[a, b + 1] != '#' &&     temp[a, b - 1] != '#' &&
                temp[a - 1, b] != '#' && temp[a - 1, b + 1] != '#' && temp[a - 1, b - 1] != '#' &&
                temp[a + 1, b] != '#' && temp[a + 1, b + 1] != '#' && temp[a + 1, b - 1] != '#')
            {
                temp[a, b] = '#';
                break;
            }
        }
        while (true);
    }
}
int PerevodX(string temp)
{
    int result = 0;
    if (temp == "A")        result=0;
    else if (temp == "Б")   result=1;
    else if (temp == "В")   result=2;
    else if (temp == "Г")   result=3;
    else if (temp == "Д")   result=4;
    else if (temp == "Е")   result=5;
    else if (temp == "Ж")   result=6;
    else if (temp == "З")   result=7;
    else if (temp == "И")   result=8;
    else if (temp == "К")   result=9;
    return result;
}
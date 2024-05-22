Random random = new Random();

char[,] mas1 = new char[10, 10];
char[,] mas2 = new char[10, 10];

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

//заполнение 4-х палубным кораблем
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
                poleOne[a, b + i] = '#';
            break;
        }
    }
    else if (c == 0)
    {
        if (a <= 5)
        {
            for (int i = 0; i < 4; i++)
                poleOne[a + i, b] = '#';
            break;
        }
    }
}
while (true);

//заполнение 3-х палубными кораблями
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
            if (poleOne[a, b] != '#' && poleOne[a, b + 1] != '#' && poleOne[a, b + 2] != '#' &&
                poleOne[a - 1, b] != '#' && poleOne[a - 1, b + 1] != '#' && poleOne[a - 1, b + 2] != '#' &&
                poleOne[a + 1, b] != '#' && poleOne[a + 1, b + 1] != '#' && poleOne[a + 1, b + 2] != '#' &&
                poleOne[a - 1, b - 1] != '#' && poleOne[a + 1, b - 1] != '#' &&
                poleOne[a - 1, b + 3] != '#' && poleOne[a + 1, b + 3] != '#' &&
                poleOne[a, b - 1] != '#' && poleOne[a, b + 3] != '#')
            {
                poleOne[a, b] = '#';
                poleOne[a, b + 1] = '#';
                poleOne[a, b + 2] = '#';
                break;
            }
        }
        else if (c == 1)
        {
            if (poleOne[b, a] != '#' && poleOne[b + 1, a] != '#' && poleOne[b + 2, a] != '#' &&
                poleOne[b - 1, a] != '#' && poleOne[b - 1, a + 1] != '#' && poleOne[b - 1, a + 2] != '#' &&
                poleOne[b + 1, a] != '#' && poleOne[b + 1, a + 1] != '#' && poleOne[b + 1, a + 2] != '#' &&
                poleOne[b - 1, a - 1] != '#' && poleOne[b - 1, a + 1] != '#' &&
                poleOne[b + 3, a - 1] != '#' && poleOne[b + 3, a + 1] != '#' &&
                poleOne[b - 1, a] != '#' && poleOne[b + 3, a] != '#')
            {
                poleOne[b, a] = '#';
                poleOne[b, a + 1] = '#';
                poleOne[b, a + 2] = '#';
                break;
            }
        }
    }
    while (true);
}

//Заполнение 2-х палубными кораблями
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
            if (poleOne[a, b] != '#' && poleOne[a, b + 1] != '#' &&
                poleOne[a - 1, b] != '#' && poleOne[a - 1, b + 1] != '#' &&
                poleOne[a + 1, b] != '#' && poleOne[a + 1, b + 1] != '#' &&
                poleOne[a - 1, b - 1] != '#' && poleOne[a + 1, b - 1] != '#' &&
                poleOne[a - 1, b + 2] != '#' && poleOne[a + 1, b + 2] != '#' &&
                poleOne[a, b - 1] != '#' && poleOne[a, b + 2] != '#')
            {
                poleOne[a, b] = '#';
                poleOne[a, b + 1] = '#';
                break;
            }
        }
        else if (c == 1)
        {
            if (poleOne[b, a] != '#' && poleOne[b + 1, a] != '#' &&
                poleOne[b - 1, a] != '#' && poleOne[b - 1, a + 1] != '#' &&
                poleOne[b + 1, a] != '#' && poleOne[b + 1, a + 1] != '#' &&
                poleOne[b - 1, a - 1] != '#' && poleOne[b - 1, a + 1] != '#' &&
                poleOne[b + 2, a - 1] != '#' && poleOne[b + 2, a + 1] != '#' &&
                poleOne[b - 1, a] != '#' && poleOne[b + 2, a] != '#')
            {
                poleOne[b, a] = '#';
                poleOne[b, a + 1] = '#';
                break;
            }
        }
    }
    while (true);
}

//Заполнение 1-о палубными кораблями
for (int k = 0; k < 4; k++)
{
    Random rand1 = new Random();
    Random rand2 = new Random();
    do
    {
        int a = rand1.Next(1, 9);
        int b = rand2.Next(1, 9);


        if (poleOne[a, b] != '#' && poleOne[a, b + 1] != '#' && poleOne[a, b - 1] != '#' &&
            poleOne[a - 1, b] != '#' && poleOne[a - 1, b + 1] != '#' && poleOne[a - 1, b - 1] != '#' &&
            poleOne[a + 1, b] != '#' && poleOne[a + 1, b + 1] != '#' && poleOne[a + 1, b - 1] != '#')
        {
            poleOne[a, b] = '#';
            break;
        }
    }
    while (true);
}

//for (int i = 0; i < poleOne.GetLength(0); i++)
//{
//    for (int j = 0; j < poleOne.GetLength(1); j++)
//    {
//        Console.Write(poleOne[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();

Console.WriteLine("Компьютер сформировал свое поле.");
Console.Write("Ваше поле сформировать автоматически или в ручную? (авт/руч):");
string formPole = Console.ReadLine()!;

if (formPole == "авт" || formPole == "Авт" || formPole == "авт." || formPole == "Авт.")
{
    //заполнение 4-х палубным кораблем
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
                    poleTwo[a, b + i] = '#';
                break;
            }
        }
        else if (c == 0)
        {
            if (a <= 5)
            {
                for (int i = 0; i < 4; i++)
                    poleTwo[a + i, b] = '#';
                break;
            }
        }
    }
    while (true);

    //заполнение 3-х палубными кораблями
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
                if (poleTwo[a, b] != '#' && poleTwo[a, b + 1] != '#' && poleTwo[a, b + 2] != '#' &&
                    poleTwo[a - 1, b] != '#' && poleTwo[a - 1, b + 1] != '#' && poleTwo[a - 1, b + 2] != '#' &&
                    poleTwo[a + 1, b] != '#' && poleTwo[a + 1, b + 1] != '#' && poleTwo[a + 1, b + 2] != '#' &&
                    poleTwo[a - 1, b - 1] != '#' && poleTwo[a + 1, b - 1] != '#' &&
                    poleTwo[a - 1, b + 3] != '#' && poleTwo[a + 1, b + 3] != '#' &&
                    poleTwo[a, b - 1] != '#' && poleTwo[a, b + 3] != '#')
                {
                    poleTwo[a, b] = '#';
                    poleTwo[a, b + 1] = '#';
                    poleTwo[a, b + 2] = '#';
                    break;
                }
            }
            else if (c == 1)
            {
                if (poleTwo[b, a] != '#' && poleTwo[b + 1, a] != '#' && poleTwo[b + 2, a] != '#' &&
                    poleTwo[b - 1, a] != '#' && poleTwo[b - 1, a + 1] != '#' && poleTwo[b - 1, a + 2] != '#' &&
                    poleTwo[b + 1, a] != '#' && poleTwo[b + 1, a + 1] != '#' && poleTwo[b + 1, a + 2] != '#' &&
                    poleTwo[b - 1, a - 1] != '#' && poleTwo[b - 1, a + 1] != '#' &&
                    poleTwo[b + 3, a - 1] != '#' && poleTwo[b + 3, a + 1] != '#' &&
                    poleTwo[b - 1, a] != '#' && poleTwo[b + 3, a] != '#')
                {
                    poleTwo[b, a] = '#';
                    poleTwo[b, a + 1] = '#';
                    poleTwo[b, a + 2] = '#';
                    break;
                }
            }
        }
        while (true);
    }

    //Заполнение 2-х палубными кораблями
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
                if (poleTwo[a, b] != '#' && poleTwo[a, b + 1] != '#' &&
                    poleTwo[a - 1, b] != '#' && poleTwo[a - 1, b + 1] != '#' &&
                    poleTwo[a + 1, b] != '#' && poleTwo[a + 1, b + 1] != '#' &&
                    poleTwo[a - 1, b - 1] != '#' && poleTwo[a + 1, b - 1] != '#' &&
                    poleTwo[a - 1, b + 2] != '#' && poleTwo[a + 1, b + 2] != '#' &&
                    poleTwo[a, b - 1] != '#' && poleTwo[a, b + 2] != '#')
                {
                    poleTwo[a, b] = '#';
                    poleTwo[a, b + 1] = '#';
                    break;
                }
            }
            else if (c == 1)
            {
                if (poleTwo[b, a] != '#' && poleTwo[b + 1, a] != '#' &&
                    poleTwo[b - 1, a] != '#' && poleTwo[b - 1, a + 1] != '#' &&
                    poleTwo[b + 1, a] != '#' && poleTwo[b + 1, a + 1] != '#' &&
                    poleTwo[b - 1, a - 1] != '#' && poleTwo[b - 1, a + 1] != '#' &&
                    poleTwo[b + 2, a - 1] != '#' && poleTwo[b + 2, a + 1] != '#' &&
                    poleTwo[b - 1, a] != '#' && poleTwo[b + 2, a] != '#')
                {
                    poleTwo[b, a + 1] = '#';
                    break;
                }
            }
        }
        while (true);
    }

    //Заполнение 1-о палубными кораблями
    for (int k = 0; k < 4; k++)
    {
        Random rand1 = new Random();
        Random rand2 = new Random();
        do
        {
            int a = rand1.Next(1, 9);
            int b = rand2.Next(1, 9);


            if (poleTwo[a, b] != '#' && poleTwo[a, b + 1] != '#' && poleTwo[a, b - 1] != '#' &&
                poleTwo[a - 1, b] != '#' && poleTwo[a - 1, b + 1] != '#' && poleTwo[a - 1, b - 1] != '#' &&
                poleTwo[a + 1, b] != '#' && poleTwo[a + 1, b + 1] != '#' && poleTwo[a + 1, b - 1] != '#')
            {
                poleTwo[a, b] = '#';
                break;
            }
        }
        while (true);
    }
    Console.WriteLine("Ваше поле:\n");
    for (int i = 0; i < poleTwo.GetLength(0); i++)
    {
        for (int j = 0; j < poleTwo.GetLength(1); j++)
        {
            Console.Write(poleTwo[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
else if (formPole == "руч" || formPole == "Руч" || formPole == "руч." || formPole == "Руч.")
{
    int h1 = 4;
    for (int k = 1; k <= 4; k++)
    {
        for (int h = h1; h > 0; h--)
        {
            Console.Clear();
            for (int i = 0; i < poleTwo.GetLength(0); i++)
            {
                for (int j = 0; j < poleTwo.GetLength(1); j++)
                    Console.Write(poleTwo[i, j] + " ");
                Console.WriteLine();
            }
            Console.Write($"Укажите координату {k}-х палубного коробля и направление(1,1,гор):");
            string temp = Console.ReadLine()!;
            string[] mas = temp.Split(',');

            //for (int i = 0; i < mas.Length; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}

            for (int i = 0; i < k; i++)
            {
                if (mas[2] == "гор")
                {
                    poleTwo[int.Parse(mas[0]) - 1, int.Parse(mas[1]) + i - 1] = '#';
                }
                else if (mas[2] == "вер")
                {
                    poleTwo[int.Parse(mas[0]) - 1 + i, int.Parse(mas[1]) - 1] = '#';
                }
            }

        }
        h1--;
    }
    Console.Clear();
    Console.WriteLine("Ваше поле:\n");
    for (int i = 0; i < poleTwo.GetLength(0); i++)
    {
        for (int j = 0; j < poleTwo.GetLength(1); j++)
            Console.Write(poleTwo[i, j] + " ");
        Console.WriteLine();
    }
}

Console.WriteLine("Режим игры? (авт/руч.):");
string formPlay = Console.ReadLine()!;

if (formPlay == "авт" || formPlay == "Авт" || formPlay == "авт." || formPlay == "Авт.")
{
    int count1 = 0;
    int count2 = 0;

    do
    {
        Console.Clear();
        for (int i = 0; i < mas1.GetLength(0); i++)
        {
            for (int j = 0; j < mas1.GetLength(1); j++)
            {
                Console.Write(mas1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine($"Количество попаданий: {count1}");
        Console.WriteLine();
        for (int i = 0; i < mas2.GetLength(0); i++)
        {
            for (int j = 0; j < mas2.GetLength(1); j++)
            {
                Console.Write(mas2[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine($"Количество попаданий: {count2}");
        Console.WriteLine();

        int countInsert = 0;
        do
        {
            int a = random.Next(0, 10);
            int b = random.Next(0, 10);
            if (mas1[a, b] == '*')
            //if ((mas1[a, b] != 'o' || mas1[a,b] != 'X'))
            {
                mas1[a, b] = 'o';
                countInsert++;

                if (poleTwo[a, b] == '#')
                {
                    countInsert = 0;
                    mas1[a, b] = 'X';
                    count1++;
                }
                Thread.Sleep(400);
            }
            //else if (mas1[a, b] == 'X')
            //Console.WriteLine("Ячейка занята");
        }
        while (countInsert == 0);

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
                Thread.Sleep(400);
            }
            //else if (mas2[a, b] == 'X')
            //Console.WriteLine("Ячейка занята");
        } while (countInsert2 == 0);
        if (count1 >= 20 || count2 >= 20)
            break;
    }
    while (true);

    Console.Clear();
    for (int i = 0; i < mas1.GetLength(0); i++)
    {
        for (int j = 0; j < mas1.GetLength(1); j++)
        {
            Console.Write(mas1[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int i = 0; i < mas2.GetLength(0); i++)
    {
        for (int j = 0; j < mas2.GetLength(1); j++)
        {
            Console.Write(mas2[i, j] + " ");
        }
        Console.WriteLine();
    }
    if (count1 > count2) Console.WriteLine("Победил Компьютер.");
    else if (count1 > count2) Console.WriteLine("Победил Игрок.");
    Console.WriteLine("Игра закончена!!!");
}
else if (formPlay == "руч" || formPlay == "Руч" || formPlay == "руч." || formPlay == "Руч.")
{
    int count1 = 0;
    int count2 = 0;

    do
    {
        Console.Clear();
        for (int i = 0; i < mas1.GetLength(0); i++)
        {
            for (int j = 0; j < mas1.GetLength(1); j++)
            {
                Console.Write(mas1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine(count1);
        Console.WriteLine();
        for (int i = 0; i < mas2.GetLength(0); i++)
        {
            for (int j = 0; j < mas2.GetLength(1); j++)
            {
                Console.Write(mas2[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine(count2);
        Console.WriteLine();

        int countInsert = 0;
        do
        {
            int a = random.Next(0, 10);
            int b = random.Next(0, 10);
            if (mas1[a, b] == '*')
            //if ((mas1[a, b] != 'o' || mas1[a,b] != 'X'))
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
            //else if (mas1[a, b] == 'X')
            //Console.WriteLine("Ячейка занята");
        }
        while (countInsert == 0);

        int countInsert2 = 0;
        do
        {
            Console.WriteLine("Координата Х:");
            int b2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Координата Y:");
            int a2 = int.Parse(Console.ReadLine()!);

            mas2[a2, b2] = 'o';
            countInsert2++;
            if (poleOne[a2, b2] == '#' && mas1[a2, b2] == 'o')
            {
                Console.WriteLine("Вы попали, еще одна попытка.");
                countInsert2 = 0;
                mas2[a2, b2] = 'X';
                count2++;
            }
            Thread.Sleep(200);

            //else if (mas2[a, b] == 'X')
            //Console.WriteLine("Ячейка занята");
        } while (countInsert2 == 0);
        if (count1 >= 20 || count2 >= 20)
            break;
    }
    while (true);

    Console.Clear();
    for (int i = 0; i < mas1.GetLength(0); i++)
    {
        for (int j = 0; j < mas1.GetLength(1); j++)
        {
            Console.Write(mas1[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int i = 0; i < mas2.GetLength(0); i++)
    {
        for (int j = 0; j < mas2.GetLength(1); j++)
        {
            Console.Write(mas2[i, j] + " ");
        }
        Console.WriteLine();
    }
    if (count1 > count2) Console.WriteLine("Победил Компьютер.");
    else if (count1 > count2) Console.WriteLine("Победил Игрок.");
    Console.WriteLine("Игра закончена!!!");
}
Random random = new Random();
Random random2 = new Random();
int countAll = 0;
char[,] mas=new char[10,10];
char[,] mas2 = new char[10, 10];

char[,] poleOne=new char[10, 10];
for (int i = 0; i < poleOne.GetLength(0); i++)
{
    for (int j = 0; j < poleOne.GetLength(1); j++)
    {
        poleOne[i, j]='-';
    }
}

//char[,] poleOne = { { '#', '-', '-', '-', '-', '-', '-', '-', '-', '-' },
//                    { '-', '-', '-', '-', '#', '-', '-', '-', '-', '-' },
//                    { '-', '-', '-', '-', '-', '-', '#', '#', '#', '-' },
//                    { '-', '-', '#', '-', '-', '-', '-', '-', '-', '-' },
//                    { '-', '-', '#', '-', '#', '#', '#', '#', '-', '-' },
//                    { '-', '-', '#', '-', '-', '-', '-', '-', '-', '-' },
//                    { '-', '-', '-', '-', '#', '-', '#', '-', '-', '-' },
//                    { '-', '#', '-', '-', '#', '-', '#', '-', '-', '-' },
//                    { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' },
//                    { '-', '#', '#', '-', '-', '-', '#', '-', '-', '-' } };

char[,] poleTwo = { { '-', '#', '-', '-', '-', '-', '-', '-', '-', '-' },
                    { '-', '-', '-', '-', '-', '-', '-', '#', '-', '-' },
                    { '-', '-', '#', '#', '#', '-', '-', '-', '-', '-' },
                    { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' },
                    { '-', '-', '-', '-', '#', '-', '-', '-', '-', '-' },
                    { '-', '#', '-', '-', '#', '-', '-', '#', '-', '-' },
                    { '-', '#', '-', '#', '-', '-', '-', '#', '-', '-' },
                    { '-', '#', '-', '#', '-', '#', '-', '#', '-', '-' },
                    { '-', '-', '-', '-', '-', '-', '-', '#', '-', '-' },
                    { '-', '-', '#', '-', '#', '#', '-', '-', '-', '-' } };

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
        if(a<=5)
        {
            for (int i = 0; i < 4; i++)
                poleOne[a + i, b] = '#';
            break;
        }
    }
}
while (true);

for (int i = 0; i < poleOne.GetLength(0); i++)
{
    for (int j = 0; j < poleOne.GetLength(1); j++)
    {
        Console.Write(poleOne[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

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

    for (int i = 0; i < poleOne.GetLength(0); i++)
    {
        for (int j = 0; j < poleOne.GetLength(1); j++)
        {
            Console.Write(poleOne[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
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

    for (int i = 0; i < poleOne.GetLength(0); i++)
    {
        for (int j = 0; j < poleOne.GetLength(1); j++)
        {
            Console.Write(poleOne[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j]='*';
//        mas2[i,j]='*';
//    }
//}
//int count1 = 0;
//int count2 = 0;

//do
//{   
//    Console.Clear();
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            Console.Write(mas[i, j]+" ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//    Console.WriteLine(count1);
//    Console.WriteLine();
//    for (int i = 0; i < mas2.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas2.GetLength(1); j++)
//        {
//            Console.Write(mas2[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//    Console.WriteLine(count2);
//    Console.WriteLine();

//    int countInsert = 0;
//    do
//    {
//        int a = random.Next(0, 10);
//        int b = random.Next(0, 10);
//        if (mas[a,b]=='*')
//        //if ((mas[a, b] != 'o' || mas[a,b] != 'X'))
//        {
//            mas[a, b] = 'o';
//            countInsert++;

//            if (poleTwo[a,b]=='#')
//            {
//                countInsert = 0;
//                mas[a, b] = 'X';
//                count1++;
//            }
//            Thread.Sleep(200);
//        }
//        //else if (mas[a, b] == 'X')
//            //Console.WriteLine("Ячейка занята");
//    }
//    while (countInsert == 0);

//    int countInsert2 = 0;
//    do
//    {
//        int a2 = random.Next(0, 10);
//        int b2 = random.Next(0, 10);
//        if (mas2[a2, b2] == '*')
//        {
//            mas2[a2, b2] = 'o';
//            countInsert2++;
//            if (poleOne[a2, b2] == '#' && mas[a2,b2]=='o')
//            {
//                countInsert2 = 0;
//                mas2[a2, b2] = 'X';
//                count2++;
//            }
//            Thread.Sleep(200);
//        }
//        //else if (mas2[a, b] == 'X')
//            //Console.WriteLine("Ячейка занята");
//    } while (countInsert2 == 0);
//    if (count1>=20||count2>=20)
//        break;    
//}
//while (true);

//Console.Clear();
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write(mas[i, j]+" ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();

//for (int i = 0; i < mas2.GetLength(0); i++)
//{
//    for (int j = 0; j < mas2.GetLength(1); j++)
//    {
//        Console.Write(mas2[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine(countAll);
//Console.WriteLine("Игра закончена!!!");
Random random = new Random();
Random random2 = new Random();
int countAll = 0;
char[,] mas=new char[10,10];
char[,] mas2 = new char[10, 10];
char[,] poleOne = { { '#', '-', '-', '-', '-', '-', '-', '-', '-', '-' },
                    { '-', '-', '-', '-', '#', '-', '-', '-', '-', '-' },
                    { '-', '-', '-', '-', '-', '-', '#', '#', '#', '-' },
                    { '-', '-', '#', '-', '-', '-', '-', '-', '-', '-' },
                    { '-', '-', '#', '-', '#', '#', '#', '#', '-', '-' },
                    { '-', '-', '#', '-', '-', '-', '-', '-', '-', '-' },
                    { '-', '-', '-', '-', '#', '-', '#', '-', '-', '-' },
                    { '-', '#', '-', '-', '#', '-', '#', '-', '-', '-' },
                    { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' },
                    { '-', '#', '#', '-', '-', '-', '#', '-', '-', '-' } };

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

for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j]='*';
        mas2[i,j]='*';
    }
}
int count1 = 0;
int count2 = 0;

do
{   
    Console.Clear();
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write(mas[i, j]+" ");
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
        if (mas[a, b] != 'O' || mas[a,b]!='X')
        {
            mas[a, b] = 'O';
            countInsert++;
            
            if (poleTwo[a,b]=='#')
            {
                countInsert = 0;
                mas[a, b] = 'X';
                count1++;
            }
            Thread.Sleep(500);
        }
        //else if (mas[a, b] == 'X')
            //Console.WriteLine("Ячейка занята");
    }
    while (countInsert == 0);

    int countInsert2 = 0;
    do
    {
        int a2 = random.Next(0, 10);
        int b2 = random.Next(0, 10);
        if (mas2[a2, b2] != 'X')
        {
            mas2[a2, b2] = 'X';
            countInsert2++;
            count2++;
            Thread.Sleep(200);
        }
        //else if (mas2[a, b] == 'X')
            //Console.WriteLine("Ячейка занята");
    } while (countInsert2 == 0);
    if (count1>20)
        break;    
}
while (true);

Console.Clear();
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write(mas[i, j]+" ");
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
Console.WriteLine(countAll);
Console.WriteLine("Игра закончена!!!");
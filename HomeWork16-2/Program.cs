char[,] array = { { ' ',' ','X','X',' ',' ' },
                  { ' ','X',' ',' ','X',' ' },
                  { 'X',' ',' ',' ',' ','X' },
                  { ' ','X','X','X','X',' ' },
                  { ' ',' ','X','X',' ',' ' },
                  { ' ',' ','X','X',' ',' ' },
                  { ' ',' ','X','X',' ',' ' },
                  { ' ',' ','X','X',' ',' ' },
                  { ' ',' ','X','X',' ',' ' },
                  { ' ',' ','X','X',' ',' ' },
                  { ' ','X','X','X','X',' ' }, };
int n = 0;
do
{
    Console.Clear();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine("Для выхода введите \"Выход\"\nВключить или выключить лампочку? (Вкл/Выкл):");
    string status= Console.ReadLine()!;
    if (status == "Вкл" || status == "вкл" || status == "Вкл." || status == "вкл.") n = 1;
    else if (status == "Выкл" || status == "выкл" || status == "Выкл." || status == "выкл.") n = 2;
    else if (status == "Выход" || status == "выход") break;
    else
    {
        Console.WriteLine("Некорректный ввод. Нажмите любую клавишу и попробуйте снова.");
        Console.ReadKey();
    }
    switch(n)
    {
        case 1: 
            {
                array[1, 2] = 'X';
                array[1, 3] = 'X';
                array[2, 1] = 'X';
                array[2, 2] = 'X';
                array[2, 3] = 'X';
                array[2, 4] = 'X';
            } break;
        case 2: 
            {
                array[1, 2] = ' ';
                array[1, 3] = ' ';
                array[2, 1] = ' ';
                array[2, 2] = ' ';
                array[2, 3] = ' ';
                array[2, 4] = ' ';
            } break;
    }
}
while (true);
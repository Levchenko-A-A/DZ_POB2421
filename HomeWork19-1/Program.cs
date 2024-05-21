// 4-1
// 3-2
// 2-3
// 1-4
//o-
using System.Threading.Channels;
Random random = new Random();
char[,] poleOne = new char[10, 10];
char[,] poleTwo = new char[10, 10];
for (int i = 0; i < poleOne.GetLength(0); i++)
    for (int j = 0; j < poleOne.GetLength(1); j++)
        poleOne[i, j] = '-';
for (int i = 0; i < poleTwo.GetLength(0); i++)
    for (int j = 0; j < poleTwo.GetLength(1); j++)
        poleTwo[i, j] = '-';
int h1 = 4;

//for (int k = 1; k <= 4; k++)
//{
//    for (int h=h1 ; h >0 ; h--)
//    {
//        Console.Write($"Укажите координату {k}-х палубного коробля и направление(1,1,гор):");
//        string temp = Console.ReadLine()!;
//        string[] mas = temp.Split(',');

//        //for (int i = 0; i < mas.Length; i++)
//        //{
//        //    Console.WriteLine(mas[i]);
//        //}

//        for (int i = 0; i < k; i++)
//        {
//            if (mas[2] == "гор")
//            {
//                poleTwo[int.Parse(mas[0]) - 1, int.Parse(mas[1]) + i - 1] = 'X';
//            }
//            else if (mas[2] == "вер")
//            {
//                poleTwo[int.Parse(mas[0]) - 1 + i, int.Parse(mas[1]) - 1] = 'X';
//            }
//        }
//        for (int i = 0; i < poleTwo.GetLength(0); i++)
//        {
//            for (int j = 0; j < poleTwo.GetLength(1); j++) Console.Write(poleTwo[i, j]);
//            Console.WriteLine();
//        }
//    //Console.Clear();
//    }
//    h1--;
//}
int temp=0;
h1 = 1;
for (int k = 4; k > 0; k--)
{
    
    for (int h = temp; h < h1 ; h++)
    {
        bool boolUp = true;
        bool boolDown = true;
        bool boolRight = true;
        bool boolLeft = true;
        int[] mas = new int[3];
        mas[0] = random.Next(1, 10);
        mas[1] = random.Next(1, 10);
        mas[2] = random.Next(0, 2);
        temp = h;
        if (mas[2] == 0 || mas[2]==1)
        {
            if (mas[0] == 0 && mas[1] == 0)
            {
                for (int i = 0; i < k; i++)
                    if (poleOne[1, i + 1] == 'X')
                        mas[0] += 1;
                        //boolDown = false;
                        //break;
                if (poleOne[0, k + 1] == 'X')
                    mas[0] += 1;
                    //boolLeft = false;
                    //break;
            }
            else if (mas[0] == 0 && mas[1] >= 10 - k)
            {
                for (int i = 0; i < k; i++)
                    if (poleOne[1, 10 - k + i] == 'X')
                        mas[0] -= 1;
                        //boolDown = false;
                        //break;
                if (poleOne[1, 10 - k - 1] == 'X')
                    //boolDown = false;
                    mas[0] -= 1;
                    //break;
            }
            else if (mas[0] == 10 && mas[1] == 0)
            {
                for (int i = 0; i < k; i++)
                    if (poleOne[9, i] == 'X')
                        mas[0] -= 1;
                        //boolUp = false;
                        //break;
                if (poleOne[10, k + 1] == 'X')
                    mas[0] -= 1;
                //boolRight = false;
                //break;
            }
            else if (mas[0] == 10 && mas[1] >= 10 - k)
            {
                for (int i = 0; i < k; i++)
                    if (poleOne[9, 10 - k + i] == 'X')
                        mas[0] -= 1;
                        //boolUp = false;
                        //break;
                if (poleOne[9, 10 - k - 1] == 'X')
                    mas[0] -= 1;
                    //boolLeft = false;
                    //break;
            }
            else if (mas[0]>0 && mas[1]>0 && mas[0]<10-k && mas[1]<10-k)
                for(int i=0;i<k;i++)
                {
                    if (poleOne[mas[0] - 1, mas[1] + i] == 'X' || poleOne[mas[0] + 1, mas[1] + i] == 'X')
                    {
                        mas[0] += 1;
                        boolUp = false;
                        boolDown = false;
                        //break;
                    }
                    //else if (poleOne[mas[0] - 1, mas[1]] == 'X' || poleOne[mas[0], mas[1] + 1] == 'X') break;
                    //else if (poleOne[mas[0] - 1, mas[1] - 1] == 'X' || poleOne[mas[0] + 1, mas[1] - 1] == 'X') break;
                    //else if (poleOne[mas[0] - 1, mas[1] - 1] == 'X' || poleOne[mas[0] + 1, mas[1] - 1] == 'X') break;
                }
        }
        //else if (mas[2] == 1) 
        //{ 

        //}
        //if (boolDown == false || boolLeft == false || boolRight == false || boolUp == false) temp++;
        //    for (int i = 0; i < mas.Length; i++)
        //{
        //    Console.WriteLine(mas[i]);
        //}
        for (int i = 0; i < k; i++)
        {
            if (mas[2] == 0)
            {
                if (k == 4 && mas[1] > 5) poleOne[mas[0] - 1, 6 + i] = 'X';
                else if(k == 3 && mas[1] > 6) poleOne[mas[0] - 1, 6 + i] = 'X';
                else poleOne[mas[0] - 1, mas[1] -1 + i ] = 'X';
            }
            if (mas[2] == 1)
            {
                if (k == 4 && mas[0] > 5) poleOne[6 + i, mas[1] - 1] = 'X'; 
                else if (k == 3 && mas[0] > 6) poleOne[6 + i, mas[1] - 1] = 'X';
                else poleOne[mas[0] - 1 + i, mas[1] - 1] = 'X';
            }
        }
        for (int i = 0; i < poleOne.GetLength(0); i++)
        {
            for (int j = 0; j < poleOne.GetLength(1); j++) Console.Write(poleOne[i, j]);
            Console.WriteLine();
        }
        Console.WriteLine();
        //Console.Clear();
    }
    h1++;
    //Console.WriteLine();
}
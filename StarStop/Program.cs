using System.Diagnostics;

//Stopwatch stpWatch = new Stopwatch();
//stpWatch.Start();
//stpWatch.Stop();
//Console.WriteLine("StopWatch: " + (stpWatch.ElapsedMilliseconds / 1000.0).ToString());

//Start() - Запускает или возобновляет измерение затраченного времени для интервала.
//Stop() - Останавливает измерение затраченного времени для интервала.
//StartNew() - Инициализирует новый экземпляр Stopwatch, задает свойство затраченного времени равным нулю и запускает измерение затраченного времени.
//GetTimestamp() - Получает текущее число тактов временного механизма.
//Elapsed - Получает общее затраченное время, измеренное текущим экземпляром.
//ElapsedMilliseconds - Получает общее затраченное время в миллисекундах, измеренное текущим экземпляром.
//ElapsedTicks - Получает общее затраченное время в тактах таймера, измеренное текущим экземпляром.
//Frequency - Получает частоту таймера в виде количества тактов в секунду. Это поле доступно только для чтения.
//long frequency = Stopwatch.Frequency; - Получает частоту таймера в виде количества тактов в секунду. Это поле доступно только для чтения.

Random random = new Random();
int[] mas = new int[100000];
int[] copyMas = new int[100000];

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(50);
    // Console.Write(mas[i] + " ");
}
Array.Copy(mas, copyMas, mas.Length);
Console.WriteLine();
Stopwatch stpWatch = new Stopwatch();
stpWatch.Start();
for (int i = 0; i < mas.Length - 1; i++)
{
    for (int j = i + 1; j < mas.Length; j++)
    {
        if (mas[i] > mas[j])
        {
            int temp = mas[i];
            mas[i] = mas[j];
            mas[j] = temp;
        }
    }
}
stpWatch.Stop();
//double temp1 = stpWatch.ElapsedMilliseconds / 1000.0;
//string temp2 = (stpWatch.ElapsedMilliseconds / 1000.0).ToString();
Console.WriteLine("StopWatch: " + (stpWatch.ElapsedMilliseconds / 1000.0).ToString());
stpWatch.Restart();
Array.Sort(copyMas);
stpWatch.Stop();
Console.WriteLine("StopWatch: " + (stpWatch.ElapsedMilliseconds / 1000.0).ToString());
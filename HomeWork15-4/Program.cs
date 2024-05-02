Random random=new Random();
int[] mas1 = new int[10];
int[] mas2 = new int[10];
int[] mas3 = new int[10];
int[] mas4 = new int[10];
object[] mas5 = new object[10];
object[] mas6 = new object[10];
object[] mas7 = new object[10];
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = random.Next(0,101);
    mas2[i] = random.Next(0,101);
    mas3[i] = random.Next(0,101);
    mas4[i] = random.Next(0,101);
}
for (int i = 0; i < mas5.Length; i++)
{
    mas5[i] = (mas1[i] + mas2[i]) / 2.0;
    mas6[i] = (mas3[i] + mas4[i]) / 2.0;
}
for (int i = 0; i < mas7.Length; i++)
{
    mas7[i] = (double)mas5[i] * (double)mas6[i];
}
for (int i = 0; i < mas1.Length; i++)
{
    Console.Write($"{mas1[i],8} ");
}
Console.WriteLine();
for (int i = 0; i < mas2.Length; i++)
{
    Console.Write($"{mas2[i],8} ");
}
Console.WriteLine();
for (int i = 0; i < mas3.Length; i++)
{
    Console.Write($"{mas3[i],8} ");
}
Console.WriteLine();
for (int i = 0; i < mas4.Length; i++)
{
    Console.Write($"{mas4[i],8} ");
}
Console.WriteLine();
for (int i = 0; i < mas5.Length; i++)
{
    Console.Write($"{mas5[i],8} ");
}
Console.WriteLine();
for (int i = 0; i < mas6.Length; i++)
{
    Console.Write($"{mas6[i],8} ");
}
Console.WriteLine();
for (int i = 0; i < mas7.Length; i++)
{
    Console.Write($"{mas7[i],8} ");
}
Console.WriteLine();
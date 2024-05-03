Random random=new Random();
int n = random.Next(10, 20);
int[] mas1 = new int[n];
int[] mas2 = new int[n];
int[] mas3 = new int[n];
int[] mas4 = new int[n];
object[] mas5 = new object[n*3];
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = random.Next(0,51);
    mas2[i] = random.Next(0,51);
    mas3[i] = random.Next(0,51);
    mas4[i] = random.Next(0,51);
}
for (int i = 0; i < n; i++)
{
    mas5[i] = (mas1[i] + mas2[i]) / 2.0;
    mas5[i + n] = (mas3[i] + mas4[i]) / 2.0;
}
for (int i = 0; i < n; i++)
{
    double temp1 = (double)mas5[i];
    double temp2 = (double)mas5[i + n];
    mas5[i + n * 2] = temp1 * temp2;
}
Console.WriteLine(n);
for (int i = 0; i < mas1.Length; i++) Console.Write($"{mas1[i],7} ");
Console.WriteLine();
for (int i = 0; i < mas2.Length; i++) Console.Write($"{mas2[i],7} ");
Console.WriteLine();
for (int i = 0; i < mas3.Length; i++) Console.Write($"{mas3[i],7} ");
Console.WriteLine();
for (int i = 0; i < mas4.Length; i++) Console.Write($"{mas4[i],7} ");
Console.WriteLine();
for (int i = 0; i < n*3; i++)
{ 
    Console.Write($"{mas5[i],7:F2} "); 
    if(i==n-1||i==n*2-1||i==n*3-1) Console.WriteLine();
}
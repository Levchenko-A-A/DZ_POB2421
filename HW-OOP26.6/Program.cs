GetFactAsync(5);
for (int i = 1; i <= 10; i++)
{
    Thread.Sleep(i * 1000);
    Console.WriteLine($"Секунда: {i}");
}


static async void GetFactAsync(int number)
{
    int result = 0;
    Console.WriteLine("Метод поиска факториала стартовал");
    await Task.Run(() => 
    { 
        result = CalculateFactorial(number);
        Console.WriteLine($"Факториал {number}= {result}");
    });
    Thread.Sleep(10000);
}
static int CalculateFactorial(int number)
{

    int fact = 1;
    for (int i = 1; i <= number; i++)
    {
        Task.Delay(250).Wait();
        fact *= i;
    }
    return fact;

}
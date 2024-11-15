
using System;
using System.Threading;

Counter counter = new Counter();
Thread incrementThread = new Thread(IncrementCounter);
Thread decrementThread = new Thread(DecrementCounter);

incrementThread.Start(counter);
decrementThread.Start(counter);

static void IncrementCounter(object obj)
{
    Counter counter = (Counter)obj;
    for (int i = 0; i < 100; i++)
    {
        Thread.Sleep(100);
        counter.Increment();
        Console.WriteLine($"Current value: {counter.GetCurrentValue()}");
    }
}

static void DecrementCounter(object obj)
{
    Counter counter = (Counter)obj;
    for (int i = 0; i<100; i++)
    {
        Thread.Sleep(100);
        counter.Decrement();
        Console.WriteLine($"Current value: {counter.GetCurrentValue()}");
    }
}


class Counter
{
    private int value;
    private object _lock = new object();

    public Counter()
    {
        value = 0;
    }

    public void Increment()
    {
        lock (_lock)
        {
            value++;
        }
    }

    public void Decrement()
    {
        lock (_lock)
        {
            value--;
        }
    }
    public int GetCurrentValue() => value;
}
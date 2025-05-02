using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(CalculateSum);
        Thread thread2 = new Thread(CalculateSum);

        Stopwatch stopwatch1 = Stopwatch.StartNew();
        thread1.Start(stopwatch1);

        Stopwatch stopwatch2 = Stopwatch.StartNew();
        thread2.Start(stopwatch2);

        thread1.Join();
        thread2.Join();
    }

    static void CalculateSum(object obj)
    {
        Stopwatch stopwatch = (Stopwatch)obj;

        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            Thread.Sleep(50); 
        }

        stopwatch.Stop();
        Console.WriteLine($"Сумма чисел от 1 до 10: {sum}");
        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
    }
}
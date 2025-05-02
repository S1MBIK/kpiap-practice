using System;
using System.Threading;

class Program
{
    static readonly object lockObject = new object(); 
    static int A, N; 

    static void Main(string[] args)
    {
        Console.WriteLine("Введите число A:");
        A = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите число N:");
        N = int.Parse(Console.ReadLine());

        Thread thread1 = new Thread(CalculateSum);
        Thread thread2 = new Thread(CalculateSum);

        thread1.Start();
        thread2.Start();

        CalculateProduct();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Программа завершена.");
    }

    static void CalculateSum()
    {
        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += A;
        }
        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Сумма = {sum}");
    }

    static void CalculateProduct()
    {
        lock (lockObject) 
        {
            int product = 1;
            for (int i = 1; i <= N; i++)
            {
                product *= A;
            }
            Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Произведение = {product}");
        }
    }
}
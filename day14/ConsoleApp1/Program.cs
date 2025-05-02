using System;
using System.Threading;

class Program
{
    static AutoResetEvent event1 = new AutoResetEvent(true);
    static AutoResetEvent event2 = new AutoResetEvent(false);
    static AutoResetEvent event3 = new AutoResetEvent(false);

    static void Main(string[] args)
    {
        Thread thread1 = new Thread(PrintNumbers1);
        Thread thread2 = new Thread(PrintNumbers2);
        Thread thread3 = new Thread(PrintNumbers3);

        // Устанавливаем приоритеты потоков (можно изменить)
        thread1.Priority = ThreadPriority.Highest;
        thread2.Priority = ThreadPriority.Normal;
        thread3.Priority = ThreadPriority.Lowest;

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Все потоки завершили работу.");
    }

    static void PrintNumbers1()
    {
        for (int i = 0; i < 10; i++)
        {
            event1.WaitOne(); 
            Console.WriteLine($"Поток 1: {i}");
            Thread.Sleep(100);
            event2.Set(); 
        }
    }

    static void PrintNumbers2()
    {
        for (int i = 10; i < 20; i++)
        {
            event2.WaitOne(); 
            Console.WriteLine($"Поток 2: {i}");
            Thread.Sleep(100); 
            event3.Set(); 
        }
    }

    static void PrintNumbers3()
    {
        for (int i = 20; i < 30; i++)
        {
            event3.WaitOne(); 
            Console.WriteLine($"Поток 3: {i}");
            Thread.Sleep(100); 
            event1.Set(); 
        }
    }
}
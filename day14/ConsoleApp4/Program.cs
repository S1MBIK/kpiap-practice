using System;
using System.Threading;

class Program
{
    static int[] numbers; 
    static int threadsCount; 
    static int[] partialSums; 

    static void Main(string[] args)
    {
        
        Console.WriteLine("Введите количество элементов в массиве:");
        int n = int.Parse(Console.ReadLine());

        numbers = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            numbers[i] = rnd.Next(1, 100); 
        }

        Console.WriteLine("Сгенерированный массив:");
        Console.WriteLine(string.Join(", ", numbers));

        Console.WriteLine("Введите количество потоков:");
        threadsCount = int.Parse(Console.ReadLine());
        partialSums = new int[threadsCount];

        Thread[] threads = new Thread[threadsCount];
        for (int i = 0; i < threadsCount; i++)
        {
            int threadIndex = i; 
            threads[i] = new Thread(() => CalculatePartialSum(threadIndex));
            threads[i].Start();
        }

        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        int totalSum = 0;
        foreach (int sum in partialSums)
        {
            totalSum += sum;
        }

        Console.WriteLine($"Общая сумма четных чисел: {totalSum}");
    }

    static void CalculatePartialSum(int threadIndex)
    {
        int sum = 0;
        int elementsPerThread = numbers.Length / threadsCount;
        int start = threadIndex * elementsPerThread;
        int end = (threadIndex == threadsCount - 1) ? numbers.Length : start + elementsPerThread;

        for (int i = start; i < end; i++)
        {
            if (numbers[i] % 2 == 0) 
            {
                sum += numbers[i];
            }
        }

        partialSums[threadIndex] = sum;
        Console.WriteLine($"Поток {threadIndex}: частичная сумма = {sum} (элементы {start}-{end - 1})");
    }
}
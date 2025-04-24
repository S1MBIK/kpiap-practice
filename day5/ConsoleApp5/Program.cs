using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение n:");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n < 0)
        {
            Console.WriteLine("Пожалуйста, введите неотрицательное целое число:");
            n = Convert.ToInt32(Console.ReadLine());
        }

        double result = CalculateF(n);
        Console.WriteLine($"f({n}) = {result}");
    }

    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    static double CalculateF(int n)
    {
        long factorial = Factorial(n);
        return (1.0 + factorial) / (2.0 + factorial);
    }
}
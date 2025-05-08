using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int A = -5;
        int B = 16;

        double[] results = new double[B - A + 1];

        Parallel.For(A, B + 1, i =>
        {
            results[i - A] = Math.Sin(i * i); 
        });

       
        for (int i = 0; i < results.Length; i++)
        {
            Console.WriteLine($"x = {A + i}, sin(x^2) = {results[i]}");
        }
    }
}
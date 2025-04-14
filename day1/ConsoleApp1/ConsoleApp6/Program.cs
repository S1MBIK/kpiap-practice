using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double x = -1;

            
            double y = 7 * Math.Pow(Math.Atan(Math.Sqrt(Math.Exp(x) + 1 + Math.Abs(x))), 2);

            Console.WriteLine($"Значение y при x = {x} равно: {y}");
        }
    }
}
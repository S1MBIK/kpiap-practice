using System;

class Program
{
    static void Main()
    {
        double A = Math.PI / 6;  
        double B = 2 * Math.PI / 3; 
        int M = 10; 

        double H = (B - A) / M;

        double x = A;

        Console.WriteLine("Значения функции F(x) = sin(x^2) на отрезке [A, B]:");

        for (int i = 1; i <= M; i++)
        {
            double y = Math.Sin(x * x); 
            Console.WriteLine($"x = {x:F2}, F(x) = {y:F4}"); 
            x += H; 
        }
    }
}
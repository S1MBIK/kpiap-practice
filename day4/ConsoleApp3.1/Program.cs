using System;

class Program
{
    static void Main()
    {
        double a = 2.0; 
        double b = 1.0; 

        
        for (double x = 0; x <= 4; x += 1) 
        {
            double result = f(x, a, b);
            Console.WriteLine($"f({x}) = {result}");
        }
    }

    static double f(double x, double a, double b)
    {
        if (x < a)
        {
            return a * Math.Pow(x, -1);
        }
        else if (x > a)
        {
            return (x - b) / (x + b); 
        }
        else 
        {
            return 1 + Math.Tan(x);     
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Значения угла alpha в радиусах: ");
        double alpha = Convert.ToDouble(Console.ReadLine());

        double radians = alpha * Math.PI / 180;

        double z1 = (Math.Sin(2 * radians) + Math.Sin(5 * radians) - Math.Sin(3 * radians)) /
                     (Math.Cos(radians) + 1 - 2 * Math.Pow(Math.Sin(2 * radians), 2));

        
        double z2 = 2 * Math.Sin(radians);

        
        Console.WriteLine($"z1 = {z1}");
        Console.WriteLine($"z2 = {z2}");
    }
}
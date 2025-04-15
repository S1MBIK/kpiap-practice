using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double y;

        if (x >= 1 && x <= 5)
        {
            y = Math.Log(x) + Math.Pow(Math.Cos(x), 2) * Math.Pow(x, 2);
        }
        else if (x == Math.PI)
        {
            y = Math.Pow(Math.Sin(x), 2);
        }
        else
        {
            Console.WriteLine("Значение x вне допустимого диапазона.");
            return;
        }

        Console.WriteLine($"Значение y для x = {x} равно: {y}");
    }
}
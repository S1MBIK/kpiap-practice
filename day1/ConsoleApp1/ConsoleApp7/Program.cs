using System;

namespace TrapezoidArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину первого основания a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину второго основания b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту h: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double area = (a + b) * h / 2;

            Console.WriteLine($"Площадь равна: {area}");
        }
    }
}
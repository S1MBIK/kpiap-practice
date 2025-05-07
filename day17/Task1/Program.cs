using System;
using System.Drawing;
using GeometryLibrary;

class Program
{
    static void Main()
    {
        // Пример использования Triangle
        Triangle triangle = new Triangle(3, 4, 5);
        if (triangle.IsValid())
        {
            Console.WriteLine($"Периметр треугольника: {triangle.CalculatePerimeter()}");
            Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
            Console.WriteLine($"Тип треугольника: {triangle.GetTriangleType()}");
        }
        else
        {
            Console.WriteLine("Треугольник не существует.");
        }

        // Пример использования Rectangle
        Rectangle rectangle = new Rectangle(5, 10);
        Console.WriteLine($"Периметр прямоугольника: {rectangle.()}");
        Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");
    }
}
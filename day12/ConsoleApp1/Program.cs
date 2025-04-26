using System;

class Program
{
    public delegate double CalcFigure(double radius);

    static void Main(string[] args)
    {
        CalcFigure CF;

        Console.Write("Введите радиус R: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        CF = Get_Length;
        Console.WriteLine($"Длина окружности: {CF(radius)}");

        CF = Get_Area;
        Console.WriteLine($"Площадь круга: {CF(radius)}");

        CF = Get_Volume;
        Console.WriteLine($"Объем шара: {CF(radius)}");
    }

    public static double Get_Length(double radius)
    {
        return 2 * Math.PI * radius;
    }

    public static double Get_Area(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double Get_Volume(double radius)
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }
}
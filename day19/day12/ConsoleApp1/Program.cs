using System;

/// <summary>
/// Основной класс программы
/// </summary>
class Program
{
    /// <summary>
    /// Делегат для вычисления геометрических параметров фигуры
    /// </summary>
    /// <param name="radius">Радиус фигуры</param>
    /// <returns>Вычисленное значение параметра</returns>
    public delegate double CalcFigure(double radius);

    /// <summary>
    /// Точка входа в программу
    /// </summary>
    /// <param name="args">Аргументы командной строки</param>
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

    /// <summary>
    /// Вычисляет длину окружности
    /// </summary>
    /// <param name="radius">Радиус окружности</param>
    /// <returns>Длина окружности</returns>
    public static double Get_Length(double radius)
    {
        return 2 * Math.PI * radius;
    }

    /// <summary>
    /// Вычисляет площадь круга
    /// </summary>
    /// <param name="radius">Радиус круга</param>
    /// <returns>Площадь круга</returns>
    public static double Get_Area(double radius)
    {
        return Math.PI * radius * radius;
    }

    /// <summary>
    /// Вычисляет объем шара
    /// </summary>
    /// <param name="radius">Радиус шара</param>
    /// <returns>Объем шара</returns>
    public static double Get_Volume(double radius)
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }
}
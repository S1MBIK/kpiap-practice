using System;

/// <summary>
/// Основной класс программы
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу
    /// </summary>
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

    /// <summary>
    /// Вычисляет значение функции f(x) в зависимости от условий
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="a">Параметр a для условий функции</param>
    /// <param name="b">Параметр b для вычисления функции</param>
    /// <returns>Значение функции f(x)</returns>
    /// <remarks>
    /// Функция имеет три ветви:
    /// 1. Если x < a, то f(x) = a * (1/x)
    /// 2. Если x > a, то f(x) = (x - b) / (x + b)
    /// 3. Если x = a, то f(x) = 1 + tan(x)
    /// </remarks>
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
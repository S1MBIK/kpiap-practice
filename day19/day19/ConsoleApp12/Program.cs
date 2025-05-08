using System;

/// <summary>
/// Основной класс программы для демонстрации работы с делегатами
/// </summary>
class Program
{
    /// <summary>
    /// Делегат для выполнения математических операций
    /// </summary>
    /// <param name="x">Первое число</param>
    /// <param name="y">Второе число</param>
    /// <returns>Результат математической операции</returns>
    public delegate double MathOperation(double x, double y);

    /// <summary>
    /// Точка входа в программу
    /// </summary>
    static void Main()
    {
        Console.Write("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Создание экземпляра делегата
        MathOperation operation = Add;
        Console.WriteLine($"Сложение: {operation(a, b)}");

        // Изменение метода делегата
        operation = Multiply;
        Console.WriteLine($"Умножение: {operation(a, b)}");

        // Использование анонимного метода
        operation = delegate(double x, double y) { return Math.Pow(x, y); };
        Console.WriteLine($"Возведение в степень: {operation(a, b)}");
    }

    /// <summary>
    /// Метод для сложения двух чисел
    /// </summary>
    /// <param name="x">Первое число</param>
    /// <param name="y">Второе число</param>
    /// <returns>Сумма чисел</returns>
    static double Add(double x, double y)
    {
        return x + y;
    }

    /// <summary>
    /// Метод для умножения двух чисел
    /// </summary>
    /// <param name="x">Первое число</param>
    /// <param name="y">Второе число</param>
    /// <returns>Произведение чисел</returns>
    static double Multiply(double x, double y)
    {
        return x * y;
    }
}

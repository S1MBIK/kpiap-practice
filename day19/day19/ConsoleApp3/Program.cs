using System;

/// <summary>
/// Основной класс программы для демонстрации процедур и функций
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу
    /// </summary>
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Вызов процедуры
        PrintNumberInfo(number);

        // Вызов функции
        int factorial = CalculateFactorial(number);
        Console.WriteLine($"Факториал числа {number} равен {factorial}");
    }

    /// <summary>
    /// Процедура для вывода информации о числе
    /// </summary>
    /// <param name="number">Число для анализа</param>
    static void PrintNumberInfo(int number)
    {
        Console.WriteLine($"Число {number} {(IsEven(number) ? "четное" : "нечетное")}");
        Console.WriteLine($"Квадрат числа: {number * number}");
    }

    /// <summary>
    /// Функция для проверки четности числа
    /// </summary>
    /// <param name="number">Проверяемое число</param>
    /// <returns>True, если число четное, иначе False</returns>
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    /// <summary>
    /// Функция для вычисления факториала числа
    /// </summary>
    /// <param name="number">Число для вычисления факториала</param>
    /// <returns>Факториал числа</returns>
    static int CalculateFactorial(int number)
    {
        if (number <= 1) return 1;
        return number * CalculateFactorial(number - 1);
    }
}

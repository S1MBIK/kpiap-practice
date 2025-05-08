using System;

/// <summary>
/// Основной класс программы для демонстрации работы с делегатами для манипуляции строками
/// </summary>
class Program
{
    /// <summary>
    /// Объявляем делегат, который принимает строку и возвращает строку
    /// </summary>
    /// <param name="input">Входная строка для обработки</param>
    /// <returns>Обработанная строка</returns>
    public delegate string StringManipulator(string input);

    /// <summary>
    /// Точка входа в программу
    /// </summary>
    /// <param name="args">Аргументы командной строки</param>
    static void Main(string[] args)
    {
        StringManipulator manipulator;

        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        manipulator = ConvertToUpper;
        Console.WriteLine($"Верхний регистр: {manipulator(input)}");

        manipulator = ReverseString;
        Console.WriteLine($"Перевернутая строка: {manipulator(input)}");

        manipulator = GetStringLength;
        Console.WriteLine($"Длина строки: {manipulator(input)}");
    }

    /// <summary>
    /// Преобразует строку в верхний регистр
    /// </summary>
    /// <param name="input">Входная строка</param>
    /// <returns>Строка в верхнем регистре</returns>
    public static string ConvertToUpper(string input)
    {
        return input.ToUpper();
    }

    /// <summary>
    /// Переворачивает строку
    /// </summary>
    /// <param name="input">Входная строка</param>
    /// <returns>Перевернутая строка</returns>
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    /// <summary>
    /// Возвращает длину строки в виде строки
    /// </summary>
    /// <param name="input">Входная строка</param>
    /// <returns>Строковое представление длины входной строки</returns>
    public static string GetStringLength(string input)
    {
        return input.Length.ToString();
    }
}
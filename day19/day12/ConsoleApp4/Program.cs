using System;

/// <summary>
/// Основной класс программы для демонстрации работы с массивом делегатов и анонимными методами
/// </summary>
class Program
{
    /// <summary>
    /// Делегат для генерации случайного значения
    /// </summary>
    /// <returns>Случайное целое число</returns>
    public delegate int RandomValueGenerator();

    /// <summary>
    /// Точка входа в программу
    /// </summary>
    /// <param name="args">Аргументы командной строки</param>
    static void Main(string[] args)
    {
        /// <summary>
        /// Массив делегатов для генерации случайных чисел
        /// </summary>
        RandomValueGenerator[] generators = new RandomValueGenerator[]
        {
            GenerateRandomValue,
            GenerateRandomValue,
            GenerateRandomValue,
            GenerateRandomValue,
            GenerateRandomValue
        };

        /// <summary>
        /// Анонимный метод для вычисления среднего арифметического значений, полученных от делегатов
        /// </summary>
        /// <param name="delegates">Массив делегатов для генерации случайных чисел</param>
        /// <returns>Среднее арифметическое сгенерированных значений</returns>
        Func<RandomValueGenerator[], double> calculateAverage = delegate (RandomValueGenerator[] delegates)
        {
            int sum = 0;
            foreach (var generator in delegates)
            {
                sum += generator();
            }
            return (double)sum / delegates.Length;
        };

        double average = calculateAverage(generators);
        Console.WriteLine($"Среднее арифметическое: {average}");
    }

    /// <summary>
    /// Генерирует случайное целое число в диапазоне от 1 до 100
    /// </summary>
    /// <returns>Случайное целое число</returns>
    public static int GenerateRandomValue()
    {
        Random random = new Random();
        return random.Next(1, 101); 
    }
}
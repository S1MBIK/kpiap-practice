using System;
using System.IO;
using System.Linq;

/// <summary>
/// Основной класс программы для демонстрации работы с файлами
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу
    /// </summary>
    static void Main()
    {
        string inputFile = "input.txt";
        string outputFile = "output.txt";

        // Запись данных в файл
        WriteToFile(inputFile);

        // Чтение и обработка данных из файла
        ProcessFile(inputFile, outputFile);

        Console.WriteLine("Обработка файлов завершена.");
    }

    /// <summary>
    /// Записывает случайные числа в файл
    /// </summary>
    /// <param name="filename">Имя файла для записи</param>
    static void WriteToFile(string filename)
    {
        Random random = new Random();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            for (int i = 0; i < 10; i++)
            {
                writer.WriteLine(random.Next(1, 100));
            }
        }
    }

    /// <summary>
    /// Обрабатывает данные из входного файла и записывает результат в выходной файл
    /// </summary>
    /// <param name="inputFile">Путь к входному файлу</param>
    /// <param name="outputFile">Путь к выходному файлу</param>
    static void ProcessFile(string inputFile, string outputFile)
    {
        try
        {
            // Чтение всех чисел из файла
            var numbers = File.ReadAllLines(inputFile)
                            .Select(int.Parse)
                            .ToList();

            // Фильтрация и преобразование чисел
            var processedNumbers = numbers
                .Where(n => n % 2 == 0)
                .Select(n => n * n)
                .ToList();

            // Запись результатов в новый файл
            File.WriteAllLines(outputFile, processedNumbers.Select(n => n.ToString()));

            Console.WriteLine($"Обработано {numbers.Count} чисел");
            Console.WriteLine($"Записано {processedNumbers.Count} результатов");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при обработке файла: {ex.Message}");
        }
    }
}

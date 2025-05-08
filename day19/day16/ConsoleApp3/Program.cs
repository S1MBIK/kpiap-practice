using System;
using System.IO;
using System.Linq;

/// <summary>
/// Основной класс программы для демонстрации работы с текстовыми файлами
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Выполняет различные операции с текстовыми файлами:
    /// - Создание файла и запись строк
    /// - Чтение и вывод содержимого
    /// - Анализ строк (подсчет, измерение длины)
    /// - Создание новых файлов на основе исходного
    /// </summary>
    static void Main()
    {
        string filePath = "example.txt";

        // a) Создание файла и запись 5 строк
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Первая строка.");
            writer.WriteLine("Вторая строка, немного длиннее.");
            writer.WriteLine("Третья.");
            writer.WriteLine("Четвертая строка, самая длинная из всех.");
            writer.WriteLine("Пятая.");
        }

        // a) Вывод всего файла на экран
        Console.WriteLine("Содержимое файла:");
        string[] lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }

        // b) Подсчет количества строк
        Console.WriteLine($"\nКоличество строк: {lines.Length}");

        // c) Подсчет количества символов в каждой строке
        Console.WriteLine("Количество символов в каждой строке:");
        foreach (var line in lines)
        {
            Console.WriteLine($"\"{line}\" - {line.Length} символов");
        }

        // d) Удаление последней строки и запись в новый файл
        string newFilePath = "new_example.txt";
        File.WriteAllLines(newFilePath, lines.Take(lines.Length - 1));

        // e) Вывод строк с s1 по s2 (например, с 1 по 3)
        int s1 = 1; 
        int s2 = 3; 
        Console.WriteLine($"\nСтроки с {s1 + 1} по {s2 + 1}:");
        for (int i = s1; i <= s2 && i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }

        // f) Длина самой длинной строки
        int maxLength = lines.Max(line => line.Length);
        string longestLine = lines.First(line => line.Length == maxLength);
        Console.WriteLine($"\nСамая длинная строка: \"{longestLine}\" ({maxLength} символов)");

        // g) Вывод строк, начинающихся с заданной буквы
        char startingLetter = 'П';
        Console.WriteLine($"\nСтроки, начинающиеся на '{startingLetter}':");
        foreach (var line in lines.Where(line => line.StartsWith(startingLetter.ToString())))
        {
            Console.WriteLine(line);
        }

        // h) Переписывание строк в другой файл в обратном порядке
        string reverseFilePath = "reverse_example.txt";
        File.WriteAllLines(reverseFilePath, lines.Reverse().Select(line => line));

        Console.WriteLine($"\nФайлы созданы: {filePath}, {newFilePath}, {reverseFilePath}");
    }
}
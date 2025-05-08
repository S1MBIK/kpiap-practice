using System;
using System.IO;
using System.Linq;

/// <summary>
/// Основной класс программы для анализа текстовых строк в файле
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Создает файл со строками и выполняет различные операции анализа:
    /// - Подсчет строк с одинаковыми первой и последней буквами
    /// - Поиск самой длинной и короткой строки
    /// - Определение номера самой длинной строки
    /// - Поиск строки, начинающейся с заданной буквы
    /// </summary>
    static void Main()
    {
        string filePath = "input.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("apple");
            writer.WriteLine("banana");
            writer.WriteLine("civic");
            writer.WriteLine("deified");
            writer.WriteLine("level");
            writer.WriteLine("radar");
            writer.WriteLine("hello");
        }

        
        var lines = File.ReadAllLines(filePath).ToList();

        // 1.количество строк и проверка на начала и конец на одну и туже букву 
        int sameLetterCount = lines.Count(line => line.Length > 0 && line[0] == line[line.Length - 1]);
        Console.WriteLine($"Количество строк, начинающихся и заканчивающихся одной буквой: {sameLetterCount}");

        // 2. длиная строка и длина 
        var longestLine = lines.OrderByDescending(line => line.Length).FirstOrDefault();
        Console.WriteLine($"Самая длинная строка: \"{longestLine}\" (длина: {longestLine.Length})");

        // 3. короткая строка и длина
        var shortestLine = lines.OrderBy(line => line.Length).FirstOrDefault();
        Console.WriteLine($"Самая короткая строка: \"{shortestLine}\" (длина: {shortestLine.Length})");

        // 4. Номер самой длинной строки
        int longestLineIndex = lines.IndexOf(longestLine) + 1; 
        Console.WriteLine($"Номер самой длинной строки: {longestLineIndex}");

        // 5. проверка на наличие строки которая начинается на заданную букву 
        char searchLetter = 'c'; 
        var foundLine = lines.FirstOrDefault(line => line.StartsWith(searchLetter.ToString()));
        if (foundLine != null)
        {
            Console.WriteLine($"Строка, начинающаяся с '{searchLetter}': \"{foundLine}\"");
        }
        else
        {
            Console.WriteLine($"Строка, начинающаяся с '{searchLetter}', не найдена.");
        }
    }
}
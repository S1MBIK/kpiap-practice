using System;
using System.IO;
using System.Text;

/// <summary>
/// Основной класс программы для демонстрации инвертирования бинарных значений в текстовом файле
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Создает файл с бинарными строками, 
    /// затем инвертирует все биты (0 на 1 и 1 на 0) и записывает результат в новый файл
    /// </summary>
    static void Main()
    {
        string inputFilePath = "input.txt";   
        string outputFilePath = "output.txt";  

        using (StreamWriter writer = new StreamWriter(inputFilePath))
        {
            writer.WriteLine("01010");
            writer.WriteLine("00101");
            writer.WriteLine("11100");
            writer.WriteLine("10001");
            writer.WriteLine("00011");
        }

        string[] lines = File.ReadAllLines(inputFilePath);

        for (int i = 0; i < lines.Length; i++)
        {
            StringBuilder newLine = new StringBuilder();
            foreach (char c in lines[i])
            {
                if (c == '0')
                    newLine.Append('1');
                else if (c == '1')
                    newLine.Append('0');
                else
                    newLine.Append(c); 
            }
            lines[i] = newLine.ToString(); 
        }

        File.WriteAllLines(outputFilePath, lines);

        Console.WriteLine($"Строки из файла '{inputFilePath}' переписаны в файл '{outputFilePath}' с заменой символов.");
    }
}
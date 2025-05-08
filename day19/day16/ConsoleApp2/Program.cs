using System;
using System.IO;

/// <summary>
/// Основной класс программы для демонстрации создания директории
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Создает новую директорию с именем "New_folder"
    /// </summary>
    static void Main()
    {
        string directoryPath = "New_folder";

        Directory.CreateDirectory(directoryPath);

        Console.WriteLine($"Папка '{directoryPath}' успешно создана.");
        
    }
}
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string directoryPath = "New_folder";

        Directory.CreateDirectory(directoryPath);

        Console.WriteLine($"Папка '{directoryPath}' успешно создана.");
        
    }
}
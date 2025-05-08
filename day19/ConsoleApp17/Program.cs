using System;
using System.IO;
using System.Xml.Linq;

class CodeToXmlConverter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите путь к файлу с исходным кодом:");
        string inputFile = "D:\\!!!!!!kpiap-practice\\day19\\day3\\ConsoleApp1";

        Console.WriteLine("Введите путь для сохранения XML :");
        string outputFile = "D:\\!!!!!!kpiap-practice\\day19";

        try
        {
            ConvertCodeToXml(inputFile, outputFile);
            Console.WriteLine("Конвертация завершена успешно!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static void ConvertCodeToXml(string sourcePath, string xmlPath)
    {
        // Проверяем существование исходного файла
        if (!File.Exists(sourcePath))
        {
            throw new FileNotFoundException("Исходный файл не найден", sourcePath);
        }

        // Читаем все строки из файла
        string[] codeLines = File.ReadAllLines(sourcePath);

        // Создаем XML документ
        XDocument xmlDoc = new XDocument(
            new XElement("SourceCode",
                new XAttribute("fileName", Path.GetFileName(sourcePath)),
                new XAttribute("language", "C#"),
                new XElement("Lines",
                    from line in codeLines
                    select new XElement("Line",
                        new XAttribute("number", Array.IndexOf(codeLines, line) + 1),
                        new XCData(line) // Используем CData для сохранения форматирования
                    )
                )
            )
        );

        // Сохраняем XML файл
        xmlDoc.Save(xmlPath);
    }
}
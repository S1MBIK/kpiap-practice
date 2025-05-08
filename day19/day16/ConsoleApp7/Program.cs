using System;
using System.IO;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // 1. Вывести список всех файлов на всех локальных дисках
        Console.WriteLine("Список всех файлов на всех локальных дисках:");
        foreach (var drive in DriveInfo.GetDrives())
        {
            if (drive.IsReady)
            {
                try
                {
                    foreach (var file in Directory.GetFiles(drive.RootDirectory.FullName, "*", SearchOption.AllDirectories))
                    {
                        Console.WriteLine(file);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при доступе к {drive.Name}: {ex.Message}");
                }
            }
        }

        // 2. Создать каталог Exmple_36tp на диске D
        string targetDrive = "D:\\";
        if (!Directory.Exists(targetDrive))
        {
            Console.WriteLine("Диск D: не найден.");
            return;
        }
        string targetDir = Path.Combine(targetDrive, "Exmple_36tp");
        Directory.CreateDirectory(targetDir);

        // 3. Скопировать 3 разных файла из другого каталога на диске E
        string sourceDir = "E:\\codeC#"; // Тут надо указать какой диск и какую папку 
        if (!Directory.Exists(sourceDir))
        {
            Console.WriteLine("Исходная папка на диске E: не найдена.");
            return;
        }
        var filesToCopy = Directory.GetFiles(sourceDir).Take(3).ToArray();
        if (filesToCopy.Length < 3)
        {
            Console.WriteLine("Недостаточно файлов для копирования в исходной папке.");
            return;
        }
        string[] copiedFiles = new string[3];
        for (int i = 0; i < filesToCopy.Length; i++)
        {
            string destFile = Path.Combine(targetDir, Path.GetFileName(filesToCopy[i]));
            File.Copy(filesToCopy[i], destFile, true);
            copiedFiles[i] = destFile;
        }

        // 4. Сделать скопированные файлы скрытыми
        foreach (var file in copiedFiles)
        {
            File.SetAttributes(file, File.GetAttributes(file) | FileAttributes.Hidden);
        }

        // 5. Создать ярлыки вместо скрытых файлов
        foreach (var file in copiedFiles)
        {
            string shortcutPath = Path.Combine(targetDir, Path.GetFileNameWithoutExtension(file) + ".lnk");
            CreateShortcut(shortcutPath, file);
        }

        Console.WriteLine("Готово!");
    }

    static void CreateShortcut(string shortcutPath, string targetPath)
    {
       
        Type t = Type.GetTypeFromProgID("WScript.Shell");
        dynamic shell = Activator.CreateInstance(t);
        var shortcut = shell.CreateShortcut(shortcutPath);
        shortcut.TargetPath = targetPath;
        shortcut.Save();
    }
}
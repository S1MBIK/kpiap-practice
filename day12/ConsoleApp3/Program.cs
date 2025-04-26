using System;

class Program
{
    // Объявляем делегат, который принимает строку и возвращает строку
    public delegate string StringManipulator(string input);

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

    public static string ConvertToUpper(string input)
    {
        return input.ToUpper();
    }

    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static string GetStringLength(string input)
    {
        return input.Length.ToString();
    }
}
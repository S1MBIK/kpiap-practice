using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Привет! Это тест. #@&*() Вопрос: что?";

        string pattern = @"\b[\p{P}]+\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        Console.WriteLine("Слова, состоящие только из символов пунктуации:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
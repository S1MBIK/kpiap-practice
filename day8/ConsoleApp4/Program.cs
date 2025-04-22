using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Это.тест.слово.с.точками.и.еще.слова.";

        string pattern = @"\b([a-zA-ZА-Яа-яЁё]+\.)+[a-zA-ZА-Яа-яЁё]+\b";

        
        MatchCollection matches = Regex.Matches(input, pattern);

        Console.WriteLine("Слова, состоящие только из букв, разделенных точками:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
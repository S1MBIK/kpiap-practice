using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "В этом тексте есть слова 123, тест1 и 456abc, а также обычные слова.";

        string pattern = @"\b\w*\d\w*\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        Console.WriteLine("Слова, содержащие хотя бы одну цифру:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
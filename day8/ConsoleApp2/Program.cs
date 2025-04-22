using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Аист и астра - красивые слова, которые начинаются на A или а.";

        string pattern = @"\b[AaАа]\w*";

        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);

        MatchCollection matches = regex.Matches(text);

        Console.WriteLine("Найденные слова, начинающиеся с 'A' или 'а':");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}

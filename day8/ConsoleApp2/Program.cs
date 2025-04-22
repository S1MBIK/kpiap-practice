using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Аист и астра - красивые слова, которые начинаются на A или а.";

        string[] words = Regex.Split(input, @"\W+");

        string pattern = @"^[Aа]\w*";

        Console.WriteLine("Слова, начинающиеся с 'A' или 'а':");
        foreach (string word in words)
        {
            if (Regex.IsMatch(word, pattern))
            {
                Console.WriteLine(word);
            }
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        string input = "Пример сообщения ";
        char endChar = 'я'; 

        string result = RemoveWordsEndingWith(input, endChar);
        Console.WriteLine(result);
    }

    static string RemoveWordsEndingWith(string input, char endChar)
    {
        return string.Join(" ", input.Split(' ')
                                      .Where(word => !word.EndsWith(endChar)));
    }
}
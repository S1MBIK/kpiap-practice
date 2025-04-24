using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (words.Length < 3)
        {
            Console.WriteLine("Недостаточно слов в предложении.");
            return;
        }

        SwapFirstAndLast(words);
        Console.WriteLine("После замены первого и последнего слов: " + string.Join(" ", words));

        words = ConcatenateSecondAndThird(words);
        Console.WriteLine("После склеивания второго и третьего слов: " + string.Join(" ", words));

        if (words.Length > 2)
        {
            Console.WriteLine("Третье слово в обратном порядке: " + ReverseWord(words[2]));
        }

        if (words.Length > 0)
        {
            Console.WriteLine("Первое слово после удаления первых двух букв: " + RemoveFirstTwoLetters(words[0]));
        }
    }

    static void SwapFirstAndLast(string[] words)
    {
        string temp = words[0];
        words[0] = words[words.Length - 1];
        words[words.Length - 1] = temp;
    }

    static string[] ConcatenateSecondAndThird(string[] words)
    {
        words[1] += words[2];
        Array.Copy(words, 3, words, 2, words.Length - 3);
        Array.Resize(ref words, words.Length - 1);
        return words;
    }

    static string ReverseWord(string word)
    {
        char[] chars = word.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    static string RemoveFirstTwoLetters(string word)
    {
        if (word.Length > 2)
        {
            return word.Substring(2);
        }
        return word;
    }
}
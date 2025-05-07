using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "random_text.txt";
        CreateRandomFile(filePath, 100);

        
        Queue<char> nonDigitQueue = new Queue<char>();
        Queue<char> digitQueue = new Queue<char>();

        
        foreach (char c in File.ReadAllText(filePath))
        {
            if (char.IsDigit(c))
            {
                digitQueue.Enqueue(c); 
            }
            else
            {
                nonDigitQueue.Enqueue(c);  
            }
        }

        while (nonDigitQueue.Count > 0)
        {
            Console.Write(nonDigitQueue.Dequeue());
        }

        while (digitQueue.Count > 0)
        {
            Console.Write(digitQueue.Dequeue());
        }
    }

    static void CreateRandomFile(string filePath, int length)
    {
        Random random = new Random();
        char[] randomChars = new char[length];

        for (int i = 0; i < length; i++)
        {
           
            randomChars[i] = random.Next(0, 36) < 10
                ? (char)('0' + random.Next(0, 10)) 
                : (char)('a' + random.Next(0, 26)); 
        }

        File.WriteAllText(filePath, new string(randomChars));
    }
}
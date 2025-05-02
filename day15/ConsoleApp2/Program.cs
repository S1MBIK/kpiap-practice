using System;

class Program
{
    static void Main()
    {
        MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

        myDictionary.Add("один", 1);
        myDictionary.Add("два", 2);
        myDictionary.Add("три", 3);
        myDictionary.Add("четыре", 4);

        Console.WriteLine($"Количество пар: {myDictionary.Count}");

        Console.WriteLine($"Значение для ключа 'три': {myDictionary["три"]}");

        try
        {
            Console.WriteLine($"Значение для ключа 'пять': {myDictionary["пять"]}");
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
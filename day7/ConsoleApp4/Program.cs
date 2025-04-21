using System;

class Program
{

    public static int GetPersonalityCode(string fullName)
    {
        int sum = 0;
        foreach (char c in fullName.ToLower())
        {
            if (char.IsLetter(c))
            {

                sum += c - 'а' + 1;

            }

        }
        return ReduceToOneDigit(sum);
    }


    public static int ReduceToOneDigit(int number)
    {
        while (number > 9)
        {
            int tempSum = 0;
            while (number > 0)
            {
                tempSum += number % 10;
                number /= 10;
                Console.WriteLine(number);
            }
            number = tempSum;
        }
        return number;
    }

    static void Main()
    {

        string fullName = "Александр  Пушкин";


        int personalityCode = GetPersonalityCode(fullName);


        Console.WriteLine($"Код личности для {fullName}: {personalityCode}");
    }
}

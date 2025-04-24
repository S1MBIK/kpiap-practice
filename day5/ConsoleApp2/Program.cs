using System;

class Program
{
    static void Main()
    {
    
        int n = 10; 
        int[] numbers = new int[n];

        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            numbers[i] = random.Next(-50, 51);
        }

        Console.WriteLine("Сгенерированный массив: " + string.Join(", ", numbers));

        bool isEvenAfterOdd = false;

        for (int i = 0; i < n - 1; i++)
        {
            if (numbers[i] % 2 != 0 && numbers[i + 1] % 2 == 0)
            {
                isEvenAfterOdd = true;
                break;
            }
        }

        if (isEvenAfterOdd)
        {
            Console.WriteLine("Положительные числа в обратном порядке:");
            for (int i = n - 1; i >= 0; i--)
            {
                if (numbers[i] > 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("Отрицательные числа в обратном порядке:");
            for (int i = n - 1; i >= 0; i--)
            {
                if (numbers[i] < 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
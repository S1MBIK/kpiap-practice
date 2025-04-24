using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        // Используя оператор while
        Console.WriteLine("Числа от A до B, кратные 3 (while):");
        int i = A;
        while (i <= B)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }

        // Используя оператор do while
        Console.WriteLine("\nЧисла от A до B, кратные 3 (do while):");
        i = A;
        do
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        } while (i <= B);

        // Используя оператор for
        Console.WriteLine("\nЧисла от A до B, кратные 3 (for):");
        for (int j = A; j <= B; j++)
        {
            if (j % 3 == 0)
            {
                Console.WriteLine(j);
            }
        }
    }
}
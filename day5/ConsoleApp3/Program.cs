using System;

class Program
{
    static void Main()
    {
        // Ввод размера матрицы
        Console.WriteLine("Введите размер матрицы N (N < 10):");
        int N = Convert.ToInt32(Console.ReadLine());
        while (N >= 10)
        {
            Console.WriteLine("Пожалуйста, введите N меньше 10:");
            N = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Введите диапазон случайных чисел (a и b):");
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение M:");
        int M = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, N];
        Random random = new Random();

        Console.WriteLine("Сгенерированная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = random.Next(a, b + 1);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        double sumLessThanM = 0;
        int countLessThanM = 0;
        int[] columnSums = new int[N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matrix[i, j] < M)
                {
                    sumLessThanM += matrix[i, j];
                    countLessThanM++;
                }
                if (matrix[i, j] > 0)
                {
                    columnSums[j] += matrix[i, j];
                }
            }
        }

        double averageLessThanM;
        if (countLessThanM > 0)
        {
            averageLessThanM = sumLessThanM / countLessThanM;
        }
        else
        {
            averageLessThanM = 0;
        }

        Console.WriteLine($"Среднее арифметическое чисел, меньших {M}: {averageLessThanM}");

        Console.WriteLine("Суммы положительных элементов каждого столбца:");
        for (int j = 0; j < N; j++)
        {
            Console.WriteLine($"Столбец {j + 1}: {columnSums[j]}");
        }
    }
}
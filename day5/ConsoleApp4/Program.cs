using System;

class Program
{
    static void Main()
    {
        const int floors = 12;
        const int apartmentsPerFloor = 4;

        int[,] residents = new int[floors, apartmentsPerFloor];

        Random random = new Random();
        for (int i = 0; i < floors; i++)
        {
            for (int j = 0; j < apartmentsPerFloor; j++)
            {
                residents[i, j] = random.Next(1, 11); 
            }
        }

        Console.WriteLine("Численность жильцов в квартирах:");
        for (int i = 0; i < floors; i++)
        {
            Console.Write($"Этаж {i + 1}: ");
            for (int j = 0; j < apartmentsPerFloor; j++)
            {
                Console.Write(residents[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int maxResidents = 0;

        for (int i = 2; i <= 3; i++) 
        {
            for (int j = 0; j < apartmentsPerFloor; j++)
            {
                if (residents[i, j] > maxResidents)
                {
                    maxResidents = residents[i, j];
                }
            }
        }

        Console.WriteLine($"Численность самой большой семьи на 3-м и 4-м этажах: {maxResidents}");
    }
}
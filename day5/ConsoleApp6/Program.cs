using System;

class Program
{
    static void Main()
    {
        int size = 7;
        int[,] spiralArray = new int[size, size];
        FillSpiral(spiralArray, size);

        Console.WriteLine("Массив, заполненный по спирали:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(spiralArray[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }
    }

    static void FillSpiral(int[,] array, int size)
    {
        int value = 1;
        int left = 0, right = size - 1, top = 0, bottom = size - 1;

        while (value <= size * size)
        {
            for (int i = left; i <= right; i++)
            {
                array[top, i] = value++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                array[i, right] = value++;
            }
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    array[bottom, i] = value++;
                }
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    array[i, left] = value++;
                }
                left++;
            }
        }
    }
}
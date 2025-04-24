using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            FildMassiv(nums);
            PrintArray(nums);
            ProvekaO(nums);
            PrintArray(nums);
        }

        static void ProvekaO(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums[i] = 0;
                }
            }
        }

        static void FildMassiv(int[] nums)
        {
            Random random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(1, 101);
            }
        }

        static void PrintArray(int[] nums)
        {
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
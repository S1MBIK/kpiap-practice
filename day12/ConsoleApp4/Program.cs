using System;

class Program
{
    public delegate int RandomValueGenerator();

    static void Main(string[] args)
    {
        RandomValueGenerator[] generators = new RandomValueGenerator[]
        {
            GenerateRandomValue,
            GenerateRandomValue,
            GenerateRandomValue,
            GenerateRandomValue,
            GenerateRandomValue
        };

        Func<RandomValueGenerator[], double> calculateAverage = delegate (RandomValueGenerator[] delegates)
        {
            int sum = 0;
            foreach (var generator in delegates)
            {
                sum += generator();
            }
            return (double)sum / delegates.Length;
        };

        double average = calculateAverage(generators);
        Console.WriteLine($"Среднее арифметическое: {average}");
    }

    public static int GenerateRandomValue()
    {
        Random random = new Random();
        return random.Next(1, 101); 
    }
}
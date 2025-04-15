namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;

            Console.WriteLine("введите A");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите B");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < 1 || a > 10 || b < 1 || b > 10 || a >= b)
            {
                Console.WriteLine("Введены некорректные значения A и B. Убедитесь, что 1 <= A < B <= 10.");
                return;
            }
            for (int i = a;i < b;i++)
            {
                sumOfSquares += i * i;
                Console.WriteLine(sumOfSquares);
            }
            Console.WriteLine($"общая суммая квадратов {sumOfSquares}");
        }
    }
}

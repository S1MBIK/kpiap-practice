namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите a1");
            double a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите b1");
            double b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите a2");
            double a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите b2");
            double b2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите c2");
            double c2 = Convert.ToInt32(Console.ReadLine());

            double result = subMod(a1, b1);
            double result2 = subMod(a2, b2,c2);
            Console.WriteLine($"результат1 {result}");
            Console.WriteLine($"результат2 {result2}");
        }

        static double subMod(double a, double b)
        {
            return Math.Abs(a - b);
        }

        static double subMod(double a, double b, double c)
        {
            return Math.Abs(a - b - b);
        }
    }
}

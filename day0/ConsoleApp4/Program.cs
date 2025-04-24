namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double funt = 409.5;
            const double gramToKilog = 1000.0;

            Console.WriteLine("Введите вес в фунтах");
            double weightToFunt = Convert.ToDouble(Console.ReadLine());

            double weightToKilo = (funt * weightToFunt) / gramToKilog;
            Console.WriteLine($"Килограммы { weightToKilo:F2}");

        }
    }
}

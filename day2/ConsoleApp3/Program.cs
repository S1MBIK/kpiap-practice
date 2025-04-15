namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double sum = 0;
            Console.WriteLine("введите N от 1 до 10");
            double n = Convert.ToInt32(Console.ReadLine());
            if (n >= 1 && n <= 10)
            {
                for (double i = 1; i < n; i++)
                {

                    double kvadrat = Math.Pow(i, 2);
                    sum += kvadrat;

                    Console.WriteLine($"это квадрат {kvadrat} цифры {i}");
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("введите число от 1 до 10");
                return;
            }

        }
    }
}

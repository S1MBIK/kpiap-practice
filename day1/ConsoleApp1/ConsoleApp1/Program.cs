namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1 ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2 ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            int different = a - b;
            int product = a * b;

            Console.WriteLine("сумма:" + sum );
            Console.WriteLine("разность: " + different);
            Console.WriteLine("произведение: " + product);
        }
    }
}
    
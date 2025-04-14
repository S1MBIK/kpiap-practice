namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 123;
            int secondDigit = number % 100 / 10;
            int thereDigit = number % 10;
            int product = secondDigit * thereDigit;

            Console.WriteLine(product);
        }
    }
}

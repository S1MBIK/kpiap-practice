namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = 1234;
            int twoNumbers = numbers / 100;
            int threeNumbers = numbers % 100;
           
            Console.WriteLine(twoNumbers);
            Console.WriteLine(threeNumbers);
            Console.WriteLine(threeNumbers.ToString() + twoNumbers.ToString());
        }
    }
}

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = 252;
            int firstDigit = numbers / 100;
            int threeDigigt = numbers % 10;

            Console.WriteLine(numbers);
            
            if (firstDigit >threeDigigt)
                Console.WriteLine($"первая цифра трехзнач числа: {firstDigit} больше чем 3 цифра: {threeDigigt}");
            
            if (firstDigit == threeDigigt)
                Console.WriteLine("1 цифра и 3 цифра равны ");
            
            else
                Console.WriteLine($"3 цифра {threeDigigt} больше чем 1 цифра: {firstDigit}");
            

        }
    }
}

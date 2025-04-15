namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = 222;
            int firstDigit = numbers / 100;
            int secondDigit = numbers % 100 / 10;
            int threeDigit = numbers % 10;

            int difference1 = threeDigit - secondDigit;
            int difference2 = secondDigit - firstDigit;

            if (difference1 == difference2)
            {
                Console.WriteLine($"Цифры данного трехзначного числа образуют арифметическую прогрессию");
            }
            else
            {
                Console.WriteLine("ложь");
            }



        }
    }
}



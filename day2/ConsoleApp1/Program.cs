using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double candyKg = 2.50;
            const double appleKg = 1.30;
            const double cookieKg = 6.30;

            Console.WriteLine("введите количесвто конфет в кг");
            double candy = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введите количесвто яблок в кг");
            double apple = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введите количесвто печенья в кг");
            double cookie = Convert.ToDouble(Console.ReadLine());

            double totalSum = (candyKg * candy) + (appleKg * appleKg) + (cookieKg * cookie);
            Console.WriteLine($"полная сумма {totalSum}");
        }
    }
}

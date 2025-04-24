using static ConsoleApp1.Class1;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(1, 2);
        Fraction fraction2 = new Fraction(3, 4);

        Console.WriteLine($"Дробь 1: {fraction1}");
        Console.WriteLine($"Дробь 2: {fraction2}");

        Console.WriteLine($"Сложение: {fraction1} + {fraction2} = {fraction1 + fraction2}");
        Console.WriteLine($"Вычитание: {fraction1} - {fraction2} = {fraction1 - fraction2}");
        Console.WriteLine($"Умножение: {fraction1} * {fraction2} = {fraction1 * fraction2}");
        Console.WriteLine($"Деление: {fraction1} / {fraction2} = {fraction1 / fraction2}");
    }
}

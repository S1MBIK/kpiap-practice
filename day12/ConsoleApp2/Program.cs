using System;

class Program
{
    static void Main(string[] args)
    {
        Func<double, double, double> Add = (a, b) => a + b;
        Func<double, double, double> Sub = (a, b) => a - b;
        Func<double, double, double> Mul = (a, b) => a * b;
        Func<double, double, double> Div = (a, b) =>
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Ошибка: деление на ноль.");
            }
            return a / b;
        };

        Console.WriteLine("Выберите операцию: +, -, *, /");
        string operation = Console.ReadLine();

        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (operation)
        {
            case "+":
                result = Add(num1, num2);
                break;
            case "-":
                result = Sub(num1, num2);
                break;
            case "*":
                result = Mul(num1, num2);
                break;
            case "/":
                try
                {
                    result = Div(num1, num2);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                break;
            default:
                Console.WriteLine("Некорректная операция.");
                return;
        }

        Console.WriteLine($"Результат: {result}");
    }
}
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите значение x: ");
            string input = Console.ReadLine();
            double x = Convert.ToDouble(input);

            if (x <= 0 || x >= 1 && x < 1)
            {
                throw new ArgumentOutOfRangeException("x должен быть в диапазоне (0, 1) или x >= 1.");
            }

            double f;
            if (x > 0 && x < 1)
            {
                f = x * Math.Cos(x);
            }
            else if (x >= 1)
            {
                if (x == 1) throw new DivideByZeroException("Деление на ноль в выражении f.");
                f = 12.0 / (3 * x - 3);
            }
            else
            {
                throw new ArgumentOutOfRangeException("x должен быть в диапазоне (0, 1) или x >= 1.");
            }

            Console.WriteLine($"Результат функции f: f = {f}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка: неверный формат ввода. {ex.Message}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
    }
}
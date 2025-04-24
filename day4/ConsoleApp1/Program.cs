using System;

class Program
{
    static void Main()
    {
        try
        {
            // a: y = arctg(x) / (x - 3)
            Console.Write("Введите значение x для выражения a: ");
            string inputA = Console.ReadLine();
            double xA = Convert.ToDouble(inputA);
            if (xA == 3) throw new DivideByZeroException("Деление на ноль в выражении a.");

            double yA = Math.Atan(xA) / (xA - 3);
            Console.WriteLine($"Результат выражения a: y = {yA}");

            // Пример b: y = ln(x) + (5x - 3) / (x - 1)
            Console.Write("Введите значение x для выражения b: ");
            string inputB = Console.ReadLine();
            double xB = Convert.ToDouble(inputB);
            if (xB <= 0) throw new FormatException("Нельзя взять логарифм от отрицательного числа или нуля в выражении b.");
            if (xB == 1) throw new DivideByZeroException("Деление на ноль в выражении b.");

            double yB = Math.Log(xB) + (5 * xB - 3) / (xB - 1);
            Console.WriteLine($"Результат выражения b: y = {yB}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
    }
}
namespace ConsoleApp4
{
    /// <summary>
    /// Основной класс программы
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Аргументы командной строки</param>
        static void Main(string[] args)
        {
            Console.WriteLine("введите a1");
            double a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите b1");
            double b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите a2");
            double a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите b2");
            double b2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите c2");
            double c2 = Convert.ToInt32(Console.ReadLine());

            double result = subMod(a1, b1);
            double result2 = subMod(a2, b2, c2);
            Console.WriteLine($"результат1 {result}");
            Console.WriteLine($"результат2 {result2}");
        }

        /// <summary>
        /// Вычисляет модуль разности двух чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>Модуль разности |a - b|</returns>
        static double subMod(double a, double b)
        {
            return Math.Abs(a - b);
        }

        /// <summary>
        /// Вычисляет модуль разности трех чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <param name="c">Третье число</param>
        /// <returns>Модуль разности |a - b - b|</returns>
        static double subMod(double a, double b, double c)
        {
            return Math.Abs(a - b - b);
        }
    }
}

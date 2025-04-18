using System.Globalization;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число A");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число B");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число C");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число A2");
                int a2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число B2");
                int b2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число C2");
                int c2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Первые числа");
                sortDec3(a, b, c);

                Console.WriteLine("второые числа");
                sortDec3(a2, b2, c2);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("ошибка ввода данных");
            }
            catch (Exception ex)
            {
                Console.WriteLine("неизвестная ошибка ");
            }

        }

        static void sortDec3(int a, int b, int c)
        {
            int[] array = { a, b, c };
            var sortedArray = array.OrderByDescending(x => x).ToArray();

            Console.WriteLine("Числа в порядке убывания:");
            foreach (int x in sortedArray)
            {
                Console.WriteLine(x);
            }


        }

    }
}

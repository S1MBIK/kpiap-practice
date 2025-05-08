using System;

namespace TaskExample
{
    class Program
    {
        static void Main()
        {
            Task task1 = new Task(1234);
            Console.WriteLine($"Перестановка для 1234: {task1.RearrangeDigits()}");

            Task task2 = new Task(5678);
            Console.WriteLine($"Перестановка для 5678: {task2.RearrangeDigits()}");

            Task task3 = new Task(9012);
            Console.WriteLine($"Перестановка для 9012: {task3.RearrangeDigits()}");
        }
    }
}
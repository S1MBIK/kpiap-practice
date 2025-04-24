using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airport airport = new Airport(5);

            airport[123456] = new Plane("Москва", 123456, new DateTime(2024, 3, 20, 10, 30, 0));
            airport[654321] = new Plane("Санкт-Петербург", 654321, new DateTime(2024, 3, 20, 12, 45, 0));
            airport[111222] = new Plane("Сочи", 111222, new DateTime(2024, 3, 20, 14, 15, 0));

            Console.WriteLine("Информация о самолетах до сортировки:");
            airport.PrintInfo();

            Console.WriteLine("\nПоиск самолета по номеру рейса 123456:");
            Plane foundPlane = airport[123456];
            if (foundPlane != null)
                Console.WriteLine(foundPlane);

            Console.WriteLine("\nСортировка самолетов по номеру рейса:");
            airport.SortByFlightNumber();
            airport.PrintInfo();

            Console.ReadLine();
        }
    }
}

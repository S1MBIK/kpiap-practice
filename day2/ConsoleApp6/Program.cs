using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер пассажира (от 1 до 12): ");
        int passengerNumber = Convert.ToInt32(Console.ReadLine());

        if (passengerNumber < 1 || passengerNumber > 12)
        {
            Console.WriteLine("Некорректный номер. Введите номер от 1 до 12.");
            return;
        }

        switch (passengerNumber)
        {
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
                Console.WriteLine($"Пассажир {passengerNumber} грязный.");
                break;
            case 3:
            case 9:
            case 12:
                Console.WriteLine($"Пассажир {passengerNumber} исцарапанный.");
                break;
            default:
                Console.WriteLine($"Пассажир {passengerNumber} в порядке.");
                break;
        }
    }
}
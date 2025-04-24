using System;

namespace ConsoleApp2
{
    public class Plane : IComparable<Plane>
    {
        private string destination;
        private int flightNumber;
        private DateTime departureTime;

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public int FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }

        public DateTime DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }

        public Plane(string destination, int flightNumber, DateTime departureTime)
        {
            Destination = destination;
            FlightNumber = flightNumber;
            DepartureTime = departureTime;
        }

        public int CompareTo(Plane other)
        {
            if (other == null) return 1;
            return FlightNumber.CompareTo(other.FlightNumber);
        }

        public static bool operator <(Plane a, Plane b)
        {
            return a.FlightNumber < b.FlightNumber;
        }

        public static bool operator >(Plane a, Plane b)
        {
            return a.FlightNumber > b.FlightNumber;
        }

        public override string ToString()
        {
            return $"Рейс №{FlightNumber} в {Destination}, отправление: {DepartureTime}";
        }
    }
} 
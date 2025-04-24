    using System;

namespace ConsoleApp2
{
    public class Airport
    {
        private Plane[] planes;

        public Airport(int size)
        {
            planes = new Plane[size];
        }

        public Plane this[int flightNumber]
        {
            get
            {
                foreach (var plane in planes)
                {
                    if (plane != null && plane.FlightNumber == flightNumber)
                        return plane;
                }
                return null;
            }
            set
            {
                for (int i = 0; i < planes.Length; i++)
                {
                    if (planes[i] == null)
                    {
                        planes[i] = value;
                        break;
                    }
                }
            }
        }

        public void SortByFlightNumber()
        {
            Array.Sort(planes);
        }

        public void PrintInfo()
        {
            foreach (var plane in planes)
            {
                if (plane != null)
                    Console.WriteLine(plane);
            }
        }
    }
} 
using System;

namespace HomeApplianceLibrary
{
    public class WashingMachine
    {
        public string Brand { get; set; }
        public int LoadCapacity { get; set; } 
        public bool IsRunning { get; private set; }

        public WashingMachine(string brand, int loadCapacity)
        {
            Brand = brand;
            LoadCapacity = loadCapacity;
            IsRunning = false;
        }

        public void StartWash()
        {
            if (!IsRunning)
            {
                IsRunning = true;
                Console.WriteLine($"{Brand} стиральная машина запущена.");
            }
            else
            {
                Console.WriteLine($"{Brand} стиральная машина уже работает.");
            }
        }

        public void StopWash()
        {
            if (IsRunning)
            {
                IsRunning = false;
                Console.WriteLine($"{Brand} стиральная машина остановлена.");
            }
            else
            {
                Console.WriteLine($"{Brand} стиральная машина уже остановлена.");
            }
        }

        public void DisplayStatus()
        {
            string status = IsRunning ? "работает" : "остановлена";
            Console.WriteLine($"{Brand} стиральная машина {status}.");
        }
    }
}
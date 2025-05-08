using System;

namespace TaskExample
{
    public class Task
    {
        public int Number { get; set; }

        public Task(int number)
        {
            Number = number;
        }

        public int RearrangeDigits()
        {
            if (Number < 1000 || Number > 9999)
            {
                throw new ArgumentException("Число должно быть четырехзначным.");
            }
            string numberStr = Number.ToString();
           
            string rearranged = numberStr[2].ToString() + numberStr[3] + numberStr[0] + numberStr[1];
           
            return int.Parse(rearranged);
        }
    }
}
using System;

namespace TaskExample
{
    public class TaskCalculation
    {
        public int Number { get; set; }

        public TaskCalculation(int number)
        {
            if (number < 100 || number > 999)
            {
                throw new ArgumentException("Число должно быть трехзначным.");
            }
            Number = number;
        }

        public int CalculateProduct()
        {
            // Извлекаем цифры
            int secondDigit = (Number / 10) % 10;
            int lastDigit = Number % 10;          
            return secondDigit * lastDigit;       
        }
    }
}
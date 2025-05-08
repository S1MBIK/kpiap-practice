using System;
using System.Threading;

namespace TaskExample
{
    public class TaskCalculation
    {
        private double alpha;

        public TaskCalculation(double alpha)
        {
            this.alpha = alpha;
        }

        public double CalculateZ1()
        {
            // Замедление выполнения задачи
            Thread.Sleep(2000); // 2 секунды
            return (Math.Sin(2 * alpha) + Math.Sin(5 * alpha) - Math.Sin(3 * alpha)) /
                   (Math.Cos(alpha) + 1 - 2 * Math.Sin(2 * alpha));
        }

        public double CalculateZ2()
        {
            // Замедление выполнения задачи
            Thread.Sleep(2000); // 2 секунды
            return 2 * Math.Sin(alpha);
        }
    }
}
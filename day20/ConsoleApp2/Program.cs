using System;
using System.Threading.Tasks;

namespace TaskExample
{
    class Program
    {
        static async Task Main()
        {
            TaskCalculation[] tasks = new TaskCalculation[2];
            tasks[0] = new TaskCalculation(Math.PI / 4); 
            tasks[1] = new TaskCalculation(Math.PI / 6); 

           
            Task<double>[] calculations = new Task<double>[2];
            calculations[0] = Task.Run(() => tasks[0].CalculateZ1());
            calculations[1] = Task.Run(() => tasks[1].CalculateZ2());

          
            double[] results = await Task.WhenAll(calculations);
            Console.WriteLine($"Результат Z1: {results[0]}");
            Console.WriteLine($"Результат Z2: {results[1]}");

            await Task.WhenAny(calculations);
            Console.WriteLine("Хотя бы одна задача завершена.");
        }
    }
}
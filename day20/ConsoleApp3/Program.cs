using System;
using System.Threading.Tasks;

namespace TaskExample
{
    class Program
    {
        static async Task Main()
        {
            TaskCalculation task1 = new TaskCalculation(234); 

        
            Task<int> calculationTask = Task.Run(() => task1.CalculateProduct());

           
            calculationTask.ContinueWith((prevTask) =>
            {
                int result = prevTask.Result;
                Console.WriteLine($"Произведение второй и последней цифр: {result}");
            });

            await calculationTask;
        }
    }
}
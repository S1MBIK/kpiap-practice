using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] values = { 47, 16, 34, 87, 23 }; 
        ConcurrentBag<string> results = new ConcurrentBag<string>(); 

      
        Parallel.ForEach(values, value =>
        {
            long sum = 0;
            long product = 1;

            for (int i = 0; i <= value; i++)
            {
                sum += i;
                product *= i;

                if (sum > 535 || product > 535)
                {
                    results.Add($"Значение {value}: Прерывание выполнения, сумма {sum}, произведение {product}");
                    return; 
                }
            }

            results.Add($"Значение {value}: Сумма = {sum}, Произведение = {product}");
        });

        
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}
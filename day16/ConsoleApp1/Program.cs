using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numberOfNumbers = 50; 
        using (StreamWriter writer = new StreamWriter("f.txt"))
        {
            for (int i = 0; i < numberOfNumbers; i++)
            {
                writer.WriteLine(random.Next(1, 100)); 
            }
        }

        
        var numbers = File.ReadAllLines("f.txt").Select(int.Parse).ToList();

        
        var filteredNumbers = numbers.Where(num => num % 3 == 0 && num % 7 != 0);

        
        File.WriteAllLines("g.txt", filteredNumbers.Select(num => num.ToString()));

        Console.WriteLine("Файлы f.txt и g.txt созданы.");
    }
}
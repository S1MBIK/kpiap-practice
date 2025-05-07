using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var prototype = new Prototype<HikingTrip>();

        prototype.Add(new HikingTrip { Destination = "Mount Everest", Duration = 10 });
        prototype.Add(new HikingTrip { Destination = "Grand Canyon", Duration = 5 });

        Console.WriteLine("Original List:");
        prototype.Display();

        var clonedTrips = prototype.Clone();
        Console.WriteLine("\nCloned List:");
        foreach (var trip in clonedTrips)
        {
            Console.WriteLine(trip);
        }

        prototype.Remove(clonedTrips[0]); 

        Console.WriteLine("\nAfter Removal:");
        prototype.Display();

        
        int? optionalDays = null; 
        Console.WriteLine($"\nOptional Days: {optionalDays}");

       
        var dictionary = new Dictionary<string, HikingTrip>
        {
            { "Trip to Alps", new HikingTrip { Destination = "Alps", Duration = 7 } },
            { "Trip to Rockies", new HikingTrip { Destination = "Rocky Mountains", Duration = 14 } }
        };

       
        Console.WriteLine("\nDictionary Entries:");
        foreach (var entry in dictionary)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
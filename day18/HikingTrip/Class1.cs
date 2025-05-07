using System;

public class HikingTrip : ICloneable
{
    public string Destination { get; set; }
    public int Duration { get; set; } 

    public object Clone()
    {
        return new HikingTrip { Destination = this.Destination, Duration = this.Duration };
    }

    public override string ToString()
    {
        return $"Destination: {Destination}, Duration: {Duration} days";
    }
}
using System;

abstract class Vehicle
{
    protected string name;
    protected double fuelConsumption; 

    public Vehicle(string name, double fuelConsumption)
    {
        this.name = name;
        this.fuelConsumption = fuelConsumption;
    }

    public abstract void DisplayInfo();

    public double GetFuelConsumption()
    {
        return fuelConsumption;
    }
}

class Car : Vehicle
{
    private int numberOfDoors;

    public Car(string name, double fuelConsumption, int numberOfDoors)
        : base(name, fuelConsumption)
    {
        this.numberOfDoors = numberOfDoors;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Автомобиль: {name}, Расход топлива: {fuelConsumption} л/100 км, Количество дверей: {numberOfDoors}");
    }
}

class Truck : Vehicle
{
    private double loadCapacity;

    public Truck(string name, double fuelConsumption, double loadCapacity)
        : base(name, fuelConsumption)
    {
        this.loadCapacity = loadCapacity;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Грузовик: {name}, Расход топлива: {fuelConsumption} л/100 км, Грузоподъемность: {loadCapacity} т");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[5];

        vehicles[0] = new Car("Легковое авто A", 8.5, 5);
        vehicles[1] = new Truck("Грузовик B", 12.0, 5);
        vehicles[2] = new Car("Легковое авто C", 7.2, 3);
        vehicles[3] = new Truck("Грузовик D", 15.0, 10);
        vehicles[4] = new Car("Легковое авто E", 9.0, 5);

        double totalFuelConsumption = 0;
        Console.WriteLine("Информация о транспортных средствах:");
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            totalFuelConsumption += vehicle.GetFuelConsumption();
        }

        Console.WriteLine($"\nСуммарный расход топлива: {totalFuelConsumption} л/100 км");
    }
}
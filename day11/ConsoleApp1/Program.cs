using System;

class Settlement
{
    protected string name;

    public Settlement(string name)
    {
        this.name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Название населённого пункта: {name}");
    }
}

class Village : Settlement
{
    private int numberOfHouses;
    private int population;

    public Village(string name, int numberOfHouses, int population)
        : base(name)
    {
        this.numberOfHouses = numberOfHouses;
        this.population = population;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Название села: {name}, Количество домов: {numberOfHouses}, Население: {population}");
    }
}

class City : Settlement
{
    private int numberOfResidents;
    private double area;

    public City(string name, int numberOfResidents, double area)
        : base(name)
    {
        this.numberOfResidents = numberOfResidents;
        this.area = area;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Название города: {name}, Количество жителей: {numberOfResidents}, Площадь: {area}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Settlement[] settlements = new Settlement[5];

        settlements[0] = new Village("Село А", 50, 200);
        settlements[1] = new City("Город Б", 100000, 150.5);
        settlements[2] = new Village("Село В", 30, 120);
        settlements[3] = new City("Город Г", 250000, 300.75);
        settlements[4] = new Village("Село Д", 40, 150);

        Console.WriteLine("Информация о населённых пунктах:");
        foreach (var settlement in settlements)
        {
            settlement.DisplayInfo();
        }
    }
}
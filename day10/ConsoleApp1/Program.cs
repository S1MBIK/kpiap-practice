using System;

class Product
{
    private int quantity;
    private double price;

    public Product(int quantity, double price)
    {
        this.quantity = quantity;
        this.price = price;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public double GetPrice()
    {
        return price;
    }

    public virtual double Cost()
    {
        return quantity * price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"количество: {quantity}, цена: {price}");
    }
}

class Markers : Product
{
    private string name;
    private int grade;

    public Markers(int quantity, double price, string name, int grade)
        : base(quantity, price)
    {
        this.name = name;
        this.grade = grade;
    }

    public override double Cost()
    {
        return base.Cost() / Math.Sqrt(grade);
    }

    public void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"название: {name}, сорт: {grade}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product(10, 50);
        Markers markers = new Markers(20, 30, "фломастеры для рисования ", 2);

        Console.WriteLine("ифнормация о продукте:");
        product.DisplayInfo();
        Console.WriteLine($"стоимость товара: {product.Cost()}");

        Console.WriteLine("\nинформация о фломастерах:");
        markers.DisplayInfo();
        Console.WriteLine($"Стоимость фломастера: {markers.Cost():F2}");
    }
}
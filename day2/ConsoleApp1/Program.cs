using day3;

class Program
{
    static void Main(string[] args)
    {
        A obj = new A(3, 5);

        Console.WriteLine($"Значение выражения: {obj.CalculateExpression()}");
        Console.WriteLine($"Куб суммы a и b: {obj.CubeOfSum()}");
    }
}

using StatePatternLib;
using StatePatternLib.Implementations;

public class Program
{
    public static void Main()
    {
        var context = new Context(new StateA());

        context.Request(); // Вывод: Состояние A
        context.Request(); // Вывод: Состояние B
    }
}
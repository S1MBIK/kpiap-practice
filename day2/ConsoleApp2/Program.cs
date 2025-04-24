using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Republic republic = new Republic("Франция");
            republic.Describe();

            Monarchy monarchy = new Monarchy("Великобритания", "Король Чарльз III");
            monarchy.Describe();

            Kingdom kingdom = new Kingdom("Швеция", "Король Карл XVI Густав");
            kingdom.Describe();

            State state = new State("США");
            state.Describe();
        }
    }
}
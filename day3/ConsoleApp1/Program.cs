using System;

class Program
{
    static void Main()
    {
        double A1 = 1.0, B1 = 2.0, C1 = 3.0;
        double A2 = 4.0, B2 = 5.0, C2 = 6.0;

        ShiftRight3(ref A1, ref B1, ref C1);
        Console.WriteLine($"Первый набор после сдвига: A1 = {A1}, B1 = {B1}, C1 = {C1}");

        ShiftRight3(ref A2, ref B2, ref C2);
        Console.WriteLine($"Второй набор после сдвига: A2 = {A2}, B2 = {B2}, C2 = {C2}");
    }

    static void ShiftRight3(ref double A, ref double B, ref double C)
    {
        (A, B, C) = (C, A, B);

    }
}
using System;

namespace GeometryLibrary
{
    public class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public bool IsValid()
        {
            return (SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC > SideA);
        }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public double CalculateArea()
        {
            double s = CalculatePerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public string GetTriangleType()
        {
            if (SideA == SideB && SideB == SideC)
                return "Равносторонний";
            else if (SideA == SideB || SideA == SideC || SideB == SideC)
                return "Равнобедренный";
            else
                return "Разносторонний";
        }
    }
}
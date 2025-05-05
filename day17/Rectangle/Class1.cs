using System;

namespace GeometryLibrary
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
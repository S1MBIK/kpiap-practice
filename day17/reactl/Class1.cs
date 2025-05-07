using System;

namespace GeometryLibrary
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }
}
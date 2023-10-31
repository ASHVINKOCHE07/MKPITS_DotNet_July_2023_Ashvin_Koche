using System;

namespace RectangleArea
{
    class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public double CalculateArea()
        {
            return Convert.ToDouble(Width * Height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 10;

            double area = rect.CalculateArea();
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}
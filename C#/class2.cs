using System;

namespace CircleClass
{
    class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Circumference()
        {
            return 2 * Math.PI * Radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Radius = 7;

            double circumference = Convert.ToDouble(circle.Circumference());
            double area = Convert.ToDouble(circle.Area());

            Console.WriteLine("Circumference: " + circumference);
            Console.WriteLine("Area: " + area);
        }
    }
}
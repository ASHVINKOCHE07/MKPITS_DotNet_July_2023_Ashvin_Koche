using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double area;

            Console.WriteLine("Geometric Shape Area Calculator");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Quit");
                Console.Write("Enter your choice (1-4): ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter the radius of the circle: ");
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine("Area of the circle is: " + area);
                }
                else if (choice == 2)
                {
                    Console.Write("Enter the length of the rectangle: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Enter the width of the rectangle: ");
                    double width = double.Parse(Console.ReadLine());
                    area = length * width;
                    Console.WriteLine("Area of the rectangle is: " + area);
                }
                else if (choice == 3)
                {
                    Console.Write("Enter the base of the triangle: ");
                    double base = double.Parse(Console.ReadLine());
                    Console.Write("Enter the height of the triangle: ");
                    double height = double.Parse(Console.ReadLine());
                    area = 0.5 * base * height;
                    Console.WriteLine("Area of the triangle is: " + area);
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Exiting program...");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
        }
    }
}
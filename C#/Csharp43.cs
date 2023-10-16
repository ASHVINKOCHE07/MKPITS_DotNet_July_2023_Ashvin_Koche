using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double area;

            Console.WriteLine("Calculate area of geometry Shapes are as follows : ");
            Console.WriteLine("press 1 for Circle");
            Console.WriteLine("press 2 for Triangle");
            Console.WriteLine("press 3 for Rectangle");
            Console.WriteLine("press 4 for Quit");

           
                Console.Write("Enter your choice (1-4): ");
                choice =Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the radius of the circle: ");
                float radius = Convert.ToSingle(Console.ReadLine());
                area = 3.14f * radius * radius;
                Console.WriteLine("The area of the circle is: " + area);
            }
            else if(choice == 2)
            {
                int ba, hi;
                Console.WriteLine("Enter base= ");
                ba =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter height = ");
                hi = Convert.ToInt32(Console.ReadLine());
                area = 0.5* hi* ba;
                Console.WriteLine("The area of the Triangle is: " + area);
            }
            else if (choice == 3 )
            {
                int l, b;
                Console.WriteLine("Enter Length = ");
                l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter breadth = ");
                b = Convert.ToInt32(Console.ReadLine());
                area = l * b;
                Console.WriteLine("The area of the Rectangle is: " + area);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Exiting Program_____");
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            float area=0;
            Console.WriteLine("Shape Area Calculator = ");
            Console.WriteLine("Press 1 for circle = ");
            Console.WriteLine("Press 2 for rectangle =  ");
            Console.WriteLine("Press 3 for square =  ");
            Console.WriteLine("Press 4 for triangle =  ");
            Console.Write("Enter choice = ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int r;
                    Console.WriteLine("Choice = Circle ");
                    Console.WriteLine("Enter radius = ");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14f * r * r;
                    break;
                case 2:
                    Console.WriteLine("Choice = Rectangle");
                    int l, b;
                    Console.WriteLine("Enter length = ");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter breadth = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    area = l * b;
                    break;
                case 3:
                    Console.WriteLine("Choice = Square");
                    int s;
                    Console.WriteLine("Enter side length = ");
                    s = Convert.ToInt32(Console.ReadLine());
                    area = s * s;
                    break;
                case 4:
                    Console.WriteLine("Choice = Triangle");
                    int h, ba;
                    Console.WriteLine("Enter base = ");
                    ba = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter height = ");
                    h = Convert.ToInt32(Console.ReadLine());
                    area = 0.5f* ba * h;
                    break;
                    default:
                    Console.WriteLine("Invalid Input....");
                    break;

            }
            Console.WriteLine("Area = " + area);
            Console.ReadKey();
        }
    }
}

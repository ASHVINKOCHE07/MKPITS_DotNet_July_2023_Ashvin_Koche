using System;

class TriangleForming
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first angle: ");
        double angle1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second angle: ");
        double angle2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the third angle: ");
        double angle3 = double.Parse(Console.ReadLine());

        if (angle1 + angle2 + angle3 == 180)
        {
            Console.WriteLine("The triangle can be formed.");
        }
        else
        {
            Console.WriteLine("The triangle cannot be formed.");
        }
    }
}
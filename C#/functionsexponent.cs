using System;

class Program
{
    static void Main(string[] args)
    {
        int baseNumber, exponent;
        double result;

        Console.Write("Enter the base number: ");
        baseNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        exponent = Convert.ToInt32(Console.ReadLine());

        result = Math.Pow(baseNumber, exponent);

        Console.WriteLine("Result: " + result);
    }
}
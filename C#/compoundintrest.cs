using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the principal amount: ");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the rate of interest: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the number of times the interest is compounded per year: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of years: ");
        int t = Convert.ToInt32(Console.ReadLine());

        //Calculate compound interest
        double compoundInterest = p * Math.Pow((1 + r / n), n * t) - p;

        Console.WriteLine("Compound Interest: " + compoundInterest);
    }
}
using System;

class SimpleInterest
{
    static void Main(string[] args)
    {
        double principal, rate, time, simpleInterest;

        Console.Write("Enter the principal amount: ");
        principal = double.Parse(Console.ReadLine());

        Console.Write("Enter the rate of interest: ");
        rate = double.Parse(Console.ReadLine());

        Console.Write("Enter the time in years: ");
        time = double.Parse(Console.ReadLine());

        simpleInterest = principal * rate * time / 100;

        Console.WriteLine("The simple interest is: " + simpleInterest);
    }
}
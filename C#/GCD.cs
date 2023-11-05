using System;

class GCD
{
    static void Main(string[] args)
    {
        int num1, num2, gcd, cnt;

        Console.Write("Enter first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = int.Parse(Console.ReadLine());

        for (cnt = 1; cnt <= num1 && cnt <= num2; ++cnt)
        {
            if (num1 % cnt == 0 && num2 % cnt == 0)
            {
                gcd = cnt;
            }
        }

        Console.WriteLine("GCD of {0} and {1} is {2}", num1, num2, gcd);
    }
}
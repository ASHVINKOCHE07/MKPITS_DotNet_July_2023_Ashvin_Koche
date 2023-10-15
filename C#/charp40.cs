using System;

class Program
{
    static void Main(string[] args)
    {
        int digit;
        Console.Write("Enter a digit between 0 and 9: ");
        digit = int.Parse(Console.ReadLine());

        if (digit == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (digit == 1)
        {
            Console.WriteLine("One");
        }
        else if (digit == 2)
        {
            Console.WriteLine("Two");
        }
        else if (digit == 3)
        {
            Console.WriteLine("Three");
        }
        else if (digit == 4)
        {
            Console.WriteLine("Four");
        }
        else if (digit == 5)
        {
            Console.WriteLine("Five");
        }
        else if (digit == 6)
        {
            Console.WriteLine("Six");
        }
        else if (digit == 7)
        {
            Console.WriteLine("Seven");
        }
        else if (digit == 8)
        {
            Console.WriteLine("Eight");
        }
        else if (digit == 9)
        {
            Console.WriteLine("Nine");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a digit between 0 and 9.");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int monthNumber = int.Parse(Console.ReadLine());

        if (monthNumber == 1)
        {
            Console.WriteLine("January");
        }
        else if (monthNumber == 2)
        {
            Console.WriteLine("February");
        }
        else if (monthNumber == 3)
        {
            Console.WriteLine("March");
        }
        else if (monthNumber == 4)
        {
            Console.WriteLine("April");
        }
        else if (monthNumber == 5)
        {
            Console.WriteLine("May");
        }
        else if (monthNumber == 6)
        {
            Console.WriteLine("June");
        }
        else if (monthNumber == 7)
        {
            Console.WriteLine("July");
        }
        else if (monthNumber == 8)
        {
            Console.WriteLine("August");
        }
        else if (monthNumber == 9)
        {
            Console.WriteLine("September");
        }
        else if (monthNumber == 10)
        {
            Console.WriteLine("October");
        }
        else if (monthNumber == 11)
        {
            Console.WriteLine("November");
        }
        else if (monthNumber == 12)
        {
            Console.WriteLine("December");
        }
        else
        {
            Console.WriteLine("Invalid month number");
        }
    }
}
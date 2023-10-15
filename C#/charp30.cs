using System;

namespace SimpleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char operation;

            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here are the options:");
            Console.WriteLine("press 1 for Addition.");
            Console.WriteLine("press 2 for Subtraction.");
            Console.WriteLine("press 3 for Multiplication.");
            Console.WriteLine("press 4 for Division.");
            Console.WriteLine("press 5 to Exit.");
            operation = Console.ReadLine()[0];
            if (operation == '1')
            {
                Console.WriteLine("Result: " + (num1 + num2));
            }
            else if (operation == '2')
            {
                Console.WriteLine("Result: " + (num1 - num2));
            }
            else if (operation == '3')
            {
                Console.WriteLine("Result: " + (num1 * num2));
            }
            else if (operation == '4')
            {
                Console.WriteLine("Result: " + (num1 / num2));
            }
            else if (operation == '5')
            {
                Console.WriteLine("Exiting program...");
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
            Console.ReadKey();
        }
    }
}
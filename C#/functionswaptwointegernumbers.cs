using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        SwapNumbers(ref num1, ref num2);

        Console.WriteLine("Original numbers: {0}, {1}", num1, num2);
        Console.WriteLine("Swapped numbers: {0}, {1}", num2, num1);
    }

    static void SwapNumbers(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
}
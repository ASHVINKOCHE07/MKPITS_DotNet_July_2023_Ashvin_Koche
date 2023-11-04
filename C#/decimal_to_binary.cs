using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter a binary number: ");
        string binary = Console.ReadLine();

        int decimalNumber = Convert.ToInt32(binary, 2);

        Console.WriteLine("The decimal equivalent of the binary number is: " + decimalNumber);
    }
}
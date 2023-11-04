using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        int binaryNumber = 0;
        int remainder;

        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 2;
            binaryNumber = binaryNumber * 10 + remainder;
            decimalNumber /= 2;
        }

        Console.WriteLine("Binary number: " + binaryNumber);
    }
}
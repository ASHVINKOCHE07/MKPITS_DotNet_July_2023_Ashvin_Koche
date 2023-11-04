using System;

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        int decimalNumber = 255; // Change this value to convert a different decimal number
        string hexadecimalNumber = Convert.ToString(decimalNumber, 16);
        Console.WriteLine("Decimal number: " + decimalNumber);
        Console.WriteLine("Hexadecimal number: " + hexadecimalNumber);
    }
}
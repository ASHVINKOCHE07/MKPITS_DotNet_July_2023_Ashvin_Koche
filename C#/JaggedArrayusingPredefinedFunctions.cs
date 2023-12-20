/*
 * C# Program to Find the Length of the Jagged Array using Predefined Functions
 */
using System;
class Program
{
    public static void Main()
    {
        byte[][] numbers = new byte[5][];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new byte[i + 3];
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Length of row {0} is {1}", i, numbers[i].Length);
        }
        Console.Read();
    }
}
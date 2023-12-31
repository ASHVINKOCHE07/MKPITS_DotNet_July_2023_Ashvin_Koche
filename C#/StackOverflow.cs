/*
 * C# Program to Demonstrate Exception Handling for Stack Overflow
 */
using System;
class Program
{
    static void excep(int value)
    {
        Console.WriteLine(value);
        excep(++value);
    }
 
    static void Main()
    {
        try
        {
            excep(0);
        }
        catch (StackOverflowException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
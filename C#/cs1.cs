
/*
 * C# Program to Demonstrate Postfix Operator
 */
using System;
namespace Program
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int Input = 100;
            Input = Input++;
            Console.WriteLine("Number After post Increment : " + Input.ToString());
            Input = Input--;
            Console.WriteLine("Number After post Decrement : " + Input.ToString());
            Console.ReadLine();
        }
    }
}
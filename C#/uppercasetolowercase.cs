using System;

namespace UpperToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string output = input.ToLower();

            Console.WriteLine("Uppercase to lowercase: " + output);
        }
    }
}
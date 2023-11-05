using System;

namespace ConcatenateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            string result = str1 + " " + str2;

            Console.WriteLine("The concatenated string is: " + result);
        }
    }
}
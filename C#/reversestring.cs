using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";
            string revStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr += str[i];
            }
            Console.WriteLine("Original String: " + str);
            Console.WriteLine("Reverse String: " + revStr);
        }
    }
}
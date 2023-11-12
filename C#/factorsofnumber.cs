using System;

namespace FactorsOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 24;
            Console.WriteLine("Factors of " + num + " are:");
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
using System;

namespace SumOfIndividualDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = SumOfDigits(n);
            Console.WriteLine("The sum of the individual digits of {0} is {1}", n, sum);
        }

        static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
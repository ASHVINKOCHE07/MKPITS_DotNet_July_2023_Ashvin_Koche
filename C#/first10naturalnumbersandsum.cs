using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("First 10 Natural Numbers =");
            for (int count1 = 1; count1 <= 10; count1++)
            {
                Console.Write(count1);
                sum=sum+count1;
            }
            Console.WriteLine();
            Console.WriteLine("Sum 10 Natural Numbers ="+sum);
            Console.ReadKey();
        }

    }
}
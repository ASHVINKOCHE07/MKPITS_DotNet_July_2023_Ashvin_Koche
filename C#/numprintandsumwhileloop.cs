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
            int counter = 1;
            int sum = 0;
            while (counter <= 10)
            {
                Console.Write(" " + counter);
                sum = sum + counter;
                counter++;

            }
            Console.WriteLine();
            Console.WriteLine("Total sum = " + sum);

            Console.ReadKey();
        }

    }
}
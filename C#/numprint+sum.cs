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
            int count,i=1;
            int sum = 0;
            Console.WriteLine("Enter natural number upto which sum calculated");
            count=Convert.ToInt32(Console.ReadLine());   
            while (i <=count)
            {
                Console.Write(" " + i);
                sum = sum + i;
                i++;

            }
            Console.WriteLine();
            Console.WriteLine("Total sum = " + sum);

            Console.ReadKey();
        }

    }
}
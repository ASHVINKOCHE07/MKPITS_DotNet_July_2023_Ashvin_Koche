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
            int sum = 0,flag,count1;
            Console.Write("Enter an number until which loop has to run =");
            flag =Convert.ToInt32(Console.ReadLine());
             for (count1 = 1; count1 <= flag; count1++)
            {
                Console.Write(count1);
                sum = sum + count1;
            }
            Console.WriteLine();
            Console.WriteLine("Sum = {0}",sum);
            Console.ReadKey();
        }

    }
}
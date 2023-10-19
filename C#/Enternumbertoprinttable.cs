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
            int num, count;
            Console.WriteLine("Enter number to print table = ");
            num = Convert.ToInt32(Console.ReadLine());
            for (count = 1; count <= 10; count++)
            {
                Console.WriteLine("{0} x {1} = {2}", num,count, (num * count));
            }
            Console.ReadKey();
        }

    }
}
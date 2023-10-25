using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Table(int n)
        {
            for (int count=1;count<=10;count++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, count, (n * count));

            }

        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Entre Number to print table =");
            num = Convert.ToInt32(Console.ReadLine());
            Table(num);
            Console.ReadKey();
        }

    }
}
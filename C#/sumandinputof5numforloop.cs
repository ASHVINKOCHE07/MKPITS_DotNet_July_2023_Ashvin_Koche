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
            int num;
            int sum = 0;
            for(int cnt=1;cnt<=5;cnt++)
            {
                Console.WriteLine("Enter Number = ");
                num=Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("Sum of 5 No : "+sum);
            Console.ReadKey();
        }

    }
}
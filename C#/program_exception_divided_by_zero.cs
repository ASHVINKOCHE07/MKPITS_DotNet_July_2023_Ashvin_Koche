using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp236
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,n;
            Console.WriteLine("Enter number 1 ");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 ");
            n=Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = num / n;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Cannot be divided by zero");
            }
            Console.WriteLine("Result : "+res);
            Console.WriteLine("end of program.");
        }
    }
}

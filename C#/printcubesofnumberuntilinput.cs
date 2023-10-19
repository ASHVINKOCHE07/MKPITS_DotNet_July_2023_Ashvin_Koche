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
            int flag, count;
            Console.WriteLine("Enter integer upto which cubes must be printed");
            flag=Convert.ToInt32(Console.ReadLine());
            for(count=1;count<=flag;count++)
            {
                Console.WriteLine("Number is : {0} and cube of the {0} is : {1}",count,(count*count*count));
            }
            Console.ReadKey();
        }

    }
}
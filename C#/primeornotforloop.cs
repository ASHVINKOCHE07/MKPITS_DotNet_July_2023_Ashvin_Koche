using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,counter;
            int flag= 0;
            Console.WriteLine("enter number = ");
            num = Convert.ToInt32(Console.ReadLine());
            for (counter=2;counter<num; counter++)
            {
                if(num % counter == 0)
                {
                     flag = 1;
                     break;
                }

            }
            if (flag == 1)
            {
                Console.WriteLine("It is not a prime Number");
            } 
            else
            {
                Console.WriteLine("It is a prime Number");
            }
            Console.ReadKey();
        }
    }
}

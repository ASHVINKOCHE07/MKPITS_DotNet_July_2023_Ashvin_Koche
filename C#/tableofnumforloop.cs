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
            int num, counter;
            Console.WriteLine("Enter num = ");
            num=Convert.ToInt32(Console.ReadLine());
            for (counter=1;counter<=10;counter++) 
            {
                Console.WriteLine("{0}x{1}={2}",num,counter,(num*counter));
            }
            Console.ReadKey();
        }

    }
}
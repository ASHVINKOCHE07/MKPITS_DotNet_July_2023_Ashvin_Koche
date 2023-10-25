using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Prime(int n)
        {
            int p = 1;
            for (int count = 2; count < n; count++)
            {
                
                if (n % count == 0)
                {
                    p = 0;
                    break;
                }
            }
            if (p == 0)
                Console.WriteLine("Number is not prime");
            else
                Console.WriteLine("Number is prime");
         }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Entre Number to check prime or not = ");
            num = Convert.ToInt32(Console.ReadLine());
            Prime(num);
            Console.ReadKey();
        }

    }
}
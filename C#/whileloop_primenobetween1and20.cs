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
            int i=2,j,c=0;
            Console.WriteLine("Prime numbers between 1 and 20 : ");
            while (i < 20)
            {
                int isprime = 1;

                j = 2;
                while (j <= i/2)
                {
                    if (i % j == 0)
                    {
                        isprime = 0;
                        break;
                    }
                    j++;
                }
                if (isprime==1) 
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadKey();
        }

    }
}


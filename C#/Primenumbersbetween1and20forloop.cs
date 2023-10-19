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
            int count1= 2, count2;
            Console.WriteLine("Prime numbers between 1 and 20 : ");
            for (count1 = 2; count1 < 20;count1++)
            {
                int p = 1;


                for (count2=2; count2 <= count1 / 2; count2++)
                {
                    if (count1 % count2 == 0)
                    {
                        p = 0;
                        break;
                    }
                }
                if (p == 1)
                {
                    Console.WriteLine(count1);
                }
            }
            Console.ReadKey();
        }

    }
}


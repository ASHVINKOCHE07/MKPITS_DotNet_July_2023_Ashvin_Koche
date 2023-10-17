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
            int num, i=1,sum=0;

            Console.WriteLine("Enter Number : ");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Odd Numbers upto {0} : ",num);
                while (i <= num) {
                if (i % 2 != 0)
                {
                    Console.Write("{0} ", i);
                    sum = sum + i;
                }

                i++;
                }
            Console.WriteLine("");
            Console.WriteLine("The Sum of odd Natural Number upto {0} terms : {1}  " ,num,sum);
            Console.ReadKey();
        }

    }
}
          
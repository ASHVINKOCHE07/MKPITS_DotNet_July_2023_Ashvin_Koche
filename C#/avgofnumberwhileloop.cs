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
            int num, i = 1,sum=0;
            float avg;

            while (i <= 10)
            {
                Console.Write("Enter number {0} : ",i);
                num=Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
                i++;
            }
            avg = sum / 10;
            Console.WriteLine("The sum of 10 no is : {0}",sum);
            Console.WriteLine("The Average is : {0}" ,avg);

            Console.ReadKey();
        }

    }
}
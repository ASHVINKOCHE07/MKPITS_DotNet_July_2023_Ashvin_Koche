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
            int count, num,sum=0;
            float avg=0;
            Console.WriteLine("Enter 10 Numbers = ");
            for (count = 1; count <= 10; count++)
            {
                Console.Write("{0} = ",count);
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            avg = sum / 10.0f;
            Console.WriteLine("Sum ={0} ", sum);
            Console.WriteLine("Average ={0} ",avg);
            Console.ReadKey();
        }

    }
}
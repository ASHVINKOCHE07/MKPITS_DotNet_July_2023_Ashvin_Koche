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
            int i, num1 = 0, num2 = 1;
            int add = num1 + num2;
            Console.WriteLine("Enter no of terms");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0},{1}", num1, num2);
            
            for (i = 3; i <= t; i++)
            {
                Console.Write(",{0}", add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
            }
            Console.ReadKey();
        }

    }
}

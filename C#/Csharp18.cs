using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalnum
{
    class c1
    {
        public static void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter First Num = ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Num = ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
                Console.WriteLine("Numbers are equal");
            else
                Console.WriteLine("Numbers are not equal");

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenodd
{
    class c1
    {
        public static void Main()
        {
            int num1;
            Console.WriteLine("Enter First Num = ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1%2 == 0)
                Console.WriteLine("{0} it is even ",num1);
            else
                Console.WriteLine("{0} it is odd ",num1);

            Console.ReadKey();
        }
    }
}
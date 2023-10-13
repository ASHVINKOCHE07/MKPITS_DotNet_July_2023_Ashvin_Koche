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
            int num1;
            Console.WriteLine("Enter First Num = ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0)
                Console.WriteLine("Numbers is zero");
            else if (num1 > 0)
                Console.WriteLine("Numbers is positive");
            else
                Console.WriteLine("number is negative");
            Console.ReadKey();
        }
    }
}

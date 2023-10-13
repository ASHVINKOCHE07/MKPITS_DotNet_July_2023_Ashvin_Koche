using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mandn
{
    class c1
    {
        public static void Main()
        {
            int num1,num2,num3;
            Console.WriteLine("Number 1 = ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 2 = ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 3 = ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2 && num1>num3)
            {
                Console.WriteLine("{0} is largest",num1);
            }
            else if (num2>num3)

            {

                Console.WriteLine("{0} is largest", num2);
            }
            else
            {
                Console.WriteLine("{0} is largest",num3);
            }
            Console.ReadKey();
        }
    }
}

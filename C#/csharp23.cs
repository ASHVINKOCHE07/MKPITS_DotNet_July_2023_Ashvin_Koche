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
            int m,n=0;
            Console.WriteLine("Enter value of m = ");
            m = Convert.ToInt32(Console.ReadLine());
            if (m > 0)
            {
                n = 1;
                Console.WriteLine("n = {0}", n);
            }
            else if (m == 0)
            {
                n = 0;
                Console.WriteLine("n = {0}", n);
            }
            else
            {
                n = -1;
                Console.WriteLine("n = {0}", n);
            }
            Console.ReadKey();
        }
    }
}

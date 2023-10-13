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
            int h;
            Console.WriteLine("Enter Height (cm) = ");
            h = Convert.ToInt32(Console.ReadLine());
            if (h<=135)
            {
                Console.WriteLine("The person is Dwarf.");
            }
            else if (h>135 && h<=150 )

            {

                Console.WriteLine("The person is short.");
            }
            else
            {
                Console.WriteLine("The person is tall.");
            }
            Console.ReadKey();
        }
    }
}

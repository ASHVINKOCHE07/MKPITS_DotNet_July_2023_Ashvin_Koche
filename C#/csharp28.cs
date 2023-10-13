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
            sbyte a, b, c, D;
            Console.WriteLine("Input the value of a  = ");
            a = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Input the value of b  = ");
            b = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Input the value of c  = ");
            c = Convert.ToSByte(Console.ReadLine());
            D = (b * b) - (4 * a * c);
            if (D > 0)
            {
                Console.WriteLine("the quadratic equation has two real and different roots");
            }
            else if (D < 0)

            {

                Console.WriteLine("the quadratic equation has imaginary roots");
            }
            else if(D == 0)
            {
                Console.WriteLine("the quadratic equation has only one real root or two equal roots ");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }


            Console.ReadKey();
        }
    }
}


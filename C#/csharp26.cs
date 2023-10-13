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
            int x,y;
            Console.WriteLine("Enter x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y = ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x>0 && y>0)
            {
                Console.WriteLine("{0} , {1} cordinates are  in first quadrant",x,y);
            }
            else if (x > 0 && y > 0)

            {

                Console.WriteLine("{0} , {1} cordinates are  in second quadrant",x,y);
            }
            else if (x < 0 && y > 0)

            {

                Console.WriteLine("{0} , {1} cordinates are  in third quadrant", x, y);
            }
            else if (x < 0 && y < 0)

            {

                Console.WriteLine("{0} , {1} cordinates are  in third quadrant", x, y);
            }
            else if (x > 0 && y < 0)

            {

                Console.WriteLine("{0} , {1} cordinates are  in fourth quadrant", x, y);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.ReadKey();
        }
    }
}

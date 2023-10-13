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
            int rollno,phy,che,ca,total;
            string studentname,divison;
            Console.WriteLine("Enter rollno = ");
            rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name = ");
            studentname = Console.ReadLine();
            Console.WriteLine("Enter physics marks = ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter chemistry marks = ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Computer Apllication = ");
            ca = Convert.ToInt32(Console.ReadLine());
            total=phy+che+ca;
            if (total > 75)
            {
                Console.WriteLine("First Divison. ");
            }
            else if (total >= 60 && total <= 75)

            {

                Console.WriteLine("{0} , {1} cordinates are  in second quadrant", x, y);
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


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
            int phy,che,math,total;
            Console.WriteLine("Enter marks in physics = ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks in chemistry = ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks in math = ");
            math = Convert.ToInt32(Console.ReadLine());
            total=phy+che+math;
            if (math >=65 && phy >=55 && che>=50 && total>=180)
            {
                Console.WriteLine("You are Eligible for course");
            }
            else if (math >=140 && (che+phy) >= 140)

            {

                Console.WriteLine("Candidate is eligible for addmission");
            }
            else
            {
                Console.WriteLine("Candidate is not eligible for addmission");
            }

            Console.ReadKey();
        }
    }
}

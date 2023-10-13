using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eligibletovote
{
    class c1
    {
        public static void Main()
        {
            int age;
            Console.WriteLine("Enter Age = ");
            age= Convert.ToInt32(Console.ReadLine());
            if (age>=18)
                Console.WriteLine("You are eligible to vote");
            else
                Console.WriteLine("You are not eligible to vote");

            Console.ReadKey();
        }
    }
}

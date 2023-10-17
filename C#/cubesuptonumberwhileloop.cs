using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i = 1;
            Console.WriteLine("Enter num = ");
           num= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cubes upto {0} = ",num);
            while (i <= num)
            {
                Console.WriteLine("Number is : {0} and cube of the {1} is : {2} ",i,i,(i*i*i));
                i++;
            }
  
            Console.ReadKey();
        }

    }
}
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
            int cnt = 0;
            int[] arry = new int[5];
            Console.WriteLine("Enter 5 numbers of array =");
            for(cnt=0;cnt<=4;cnt++)
            {
                arry[cnt]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array Elements =");
            for (cnt = 0; cnt <=4; cnt++)
            {
                Console.WriteLine("Array[{0}]={1}", cnt,arry[cnt]);
            }

            Console.ReadKey();
        }

    }
}
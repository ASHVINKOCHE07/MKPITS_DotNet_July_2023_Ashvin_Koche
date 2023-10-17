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
            int num, i=1,j=1;

            Console.WriteLine("Enter Number : ");
            num=Convert.ToInt32(Console.ReadLine());
            while(i <=num) {
                while(j<=10){
                Console.Write("{0} x {1} = {2} , ", i, j, (i * j));
                j++;
                }
                Console.WriteLine();
                j=1;
                i++;
            }
            Console.ReadKey();
        }

    }
}
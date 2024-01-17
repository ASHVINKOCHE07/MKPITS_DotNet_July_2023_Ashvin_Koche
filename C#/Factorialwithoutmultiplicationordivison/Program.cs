using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorialwithoutmultiplicationordivison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int res;
            Console.WriteLine("Enter Number = ");
            num=Convert.ToInt32(Console.ReadLine());
            res=fact(num);
            Console.WriteLine("Factorial = " + res);
            Console.ReadKey();
        }
        public static int fact(int num)
        {
            int sum = num;
            for(int i=num-1;i>1;i--)
            {
                num = sum;
             for(int j=1;j<i;j++)
                {
                    Console.WriteLine("i={0},j={1},sum={2}",i,j,sum);
                    sum = sum +num;
                }
            }
            return sum;
        }
    }
}

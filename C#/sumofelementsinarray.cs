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
            int[] arr = new int[3];
            int sum = 0;
            int cnt = 0;
            Console.WriteLine("Enter numbers of an array");
            for (cnt = 0; cnt < arr.Length; cnt++) {
                Console.Write("Array[{0}]:",cnt);
                arr[cnt] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (cnt = 0; cnt < arr.Length; cnt++)
            {
                sum = sum + arr[cnt];

            }
            Console.WriteLine("Sum of elements of array = "+sum);
            Console.ReadKey();
        }

    }
}
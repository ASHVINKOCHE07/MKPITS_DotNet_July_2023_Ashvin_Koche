using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int cnt = 0;
            for (cnt = 0; cnt < 5; cnt++) {
                Console.WriteLine("Enter array[{0}]:", cnt);
                arr[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            for (cnt = 0; cnt < 5; cnt++)
            {
                if (arr[cnt] % 2 == 0)
                {
                    Console.WriteLine("Even element: arr[{0}]={1}",cnt, arr[cnt]);
                }
                else
                {
                    Console.WriteLine("Odd element: arr[{0}]={1}",cnt, arr[cnt]);
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    }

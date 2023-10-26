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
            int[] arr1 = new int[10];
            int cnt;
            for ( cnt = 0; cnt < arr1.Length; cnt++)
            {
                Console.WriteLine("Enter elements of arr[{0}]",cnt+1);
                arr1[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            int e;
            Console.WriteLine("Enter element to find in array");
            e=Convert.ToInt32(Console.ReadLine());
            for (cnt = 0; cnt < arr1.Length; cnt++)
            {
                if (arr1[cnt] == e)
                {
                    Console.WriteLine("{0} is present at {1} place in array", arr1[cnt],e);
                    break;
                }
                
            }

            if(arr1[cnt] != e)
            { Console.WriteLine("Element is not present in array"); 
            }
            Console.ReadKey();
        }

    }
}
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
            int[,] arr1 = { {1,2 },{3,4 } };
            int[,] arr2 = new int[2, 2];
            int[,] arr3  = new int[2, 2];
        for (int count1 = 0; count1 < 2; count1++)
        {
            for (int count2 = 0; count2 < 2; count2++)
            {
                arr3[count1, count2] = arr1[count2,count1] + arr2[count1,count2] ;   
            }
        }
            for (int count1 = 0; count1 < 2; count1++)
            {
                for (int count2 = 0; count2 < 2; count2++)
                {
                    Console.Write(arr3[count1,count2]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
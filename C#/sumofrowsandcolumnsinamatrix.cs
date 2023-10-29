using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a1 = new int[2, 2];
            
            Console.WriteLine("Enter elements of matrix");
            for (int count = 0;count<  2; count++) 
            {
                for (int count1 = 0; count1 < 2; count1++)
                {
                       a1[count,count1] = Convert.ToInt32(Console.ReadLine());
                }
                
            }
    
            
            for (int count = 0; count < 2; count++)
            {
                int sum = 0;
                for (int count1 = 0; count1 < 2; count1++)
                {
                    sum= sum + a1[count,count1];
                }
                Console.WriteLine("Sum of row of matrix = " + sum);
            }

            for (int count = 0; count < 2; count++)
            {
                int sum = 0;
                for (int count1 = 0; count1 < 2; count1++)
                {
                    sum = sum + a1[count1, count];
                }
                Console.WriteLine("Sum of columns of matrix = " + sum);
            }
            
            Console.ReadKey();
        }

    }
}
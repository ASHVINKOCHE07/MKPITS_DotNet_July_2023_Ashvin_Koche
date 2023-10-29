//program to print addition of two matrices.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a1 = new int[2, 2];
            int[,] a2 = new int[2, 2];
            int[,] add= new int[2, 2];  
            Console.WriteLine("Enter elements of matrix 1");
            for (int count=0;count<2;count++) 
            { 
                for(int count1=0;count1<2;count1++)
                {
                    a1[count,count1]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements of matrix 2");
            for (int count = 0; count < 2; count++)
            {
                for (int count1 = 0; count1 < 2; count1++)
                {
                    a2[count, count1] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int count = 0; count < 2; count++)
            {
                for (int count1 = 0; count1 < 2; count1++)
                {
                    add[count, count1] = a1[count, count1] + a2[count, count1];
                }
            
          }
            Console.WriteLine("Sum of matrix 1 and matrix 2 = ");

            for (int count = 0; count < 2; count++)
            {
                for (int count1 = 0; count1 < 2; count1++)
                {
                    Console.Write(add[count, count1]+"\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
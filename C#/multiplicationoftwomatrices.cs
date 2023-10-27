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
            int[,] a1 = new int[2,2];
            int[,] a2 = new int[2,2];
            int[,] a3 = new int[2,2];
            for (int count1=0; count1<2;count1++ ) 
            {
                for(int count2=0;count2<2;count2++)
                {
                    Console.Write("Enter [{0}][{1}] element of array 1 : ",count1,count2);
                    a1[count1, count2] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int count1 = 0; count1 < 2; count1++)
            {
                for (int count2 = 0; count2 < 2; count2++)
                {
                    Console.Write("Enter [{0}][{1}] element of array 2 : ",count1,count2);
                    a2[count1, count2] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int count1 = 0; count1 < 2; count1++)
            {
                for (int count2 = 0; count2 < 2; count2++)
                {
                    a3[count1, count2] = a1[count1, count2] * a2[count1, count2];
                }
            }
            for (int count1 = 0; count1 < 2; count1++)
            {
                for (int count2 = 0; count2 < 2; count2++)
                {
                    Console.Write(a3[count1,count2] +"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
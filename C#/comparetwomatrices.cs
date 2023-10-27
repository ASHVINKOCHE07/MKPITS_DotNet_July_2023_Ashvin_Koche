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
            int[,] a1 = new int[2, 2];
            int[,] a2 = new int[2, 2];
            for (int cnt1=0;cnt1<2;cnt1++) 
            {
                for (int cnt2 = 0; cnt2 < 2; cnt2++) 
                {
                    Console.Write("Enter element of array 1 :");
                    a1[cnt1,cnt2]=Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int cnt1 = 0; cnt1 < 2; cnt1++)
            {
                for (int cnt2 = 0; cnt2 < 2; cnt2++)
                {
                    Console.Write("Enter element of array 2 :");
                    a2[cnt1, cnt2] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int flag = 0;
            for (int cnt1 = 0; cnt1 < 2; cnt1++)
            {
                for (int cnt2 = 0; cnt2 < 2; cnt2++)
                {
                    if(a1[cnt1, cnt2] != a2[cnt1,cnt2])
                    {
                        flag = 1;
                        break;
                    }
                }
            }
            Console.WriteLine("The first matrix is : ");
            for (int cnt1 = 0; cnt1 < 2; cnt1++)
            {
                for (int cnt2 = 0; cnt2 < 2; cnt2++) { 
                    
                    Console.Write(a1[cnt1,cnt2] +"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The second matrix is :");
            for (int cnt1 = 0; cnt1 < 2; cnt1++)
            {
                for (int cnt2 = 0; cnt2 < 2; cnt2++)
                {
                    
                    Console.Write(a2[cnt1, cnt2] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The Matrices can be compared :");
            if (flag==0)
            {
                Console.WriteLine("Two matrices are equal");
            }
            else
            {
                Console.WriteLine("Two matrices are not equal");
            }
            Console.ReadKey();
        }

    }
}
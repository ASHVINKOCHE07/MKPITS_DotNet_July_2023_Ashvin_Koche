using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp243
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            try
            {
                for (int i = 0;i<=3;i++)
                {
                    Console.WriteLine(a[i]);    
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("catch block executed.");
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("End of program.");
        }
    }
}

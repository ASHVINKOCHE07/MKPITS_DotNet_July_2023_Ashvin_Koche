//getlength method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3 };
           int l= arr.GetLength(0);
            Console.WriteLine("length" + l);
            Console.ReadKey();
        }
    }
}
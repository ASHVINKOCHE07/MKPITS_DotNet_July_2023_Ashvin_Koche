using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //code for replacing two numbers with ADDITION.
            int a = 10;  
            int b = 20;
            int temp = a + b;
            a=temp-a;
            Console.WriteLine("a={0}", a);
           
            b =temp-a;
            Console.WriteLine("b={0}", b);
            //code for replacing two numbers with MULTIPLICATION.
            
            temp = a*b;
            a=temp/a;
            Console.WriteLine("a={0}", a);
            b = temp / a;
            Console.WriteLine("b={0}", b);
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}

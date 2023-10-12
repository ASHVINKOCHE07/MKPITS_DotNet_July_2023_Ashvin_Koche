using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            float b;
            Console.WriteLine("Enter Number = ");
            b=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Number = " + b);

            double b1; 
            Console.WriteLine("Enter Number = ");
            b1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("number = " + b1);

            decimal b2;
            Console.WriteLine("Enter number= ");
            b2= Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Number = " + b2);

            char ch;
            Console.WriteLine("Enter number = ");
            ch=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Char = " + ch);

            Boolean bb;
            Console.WriteLine("Enter charact");
            bb=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("char = " + bb);
            Console.ReadKey();
        }
    }
} 
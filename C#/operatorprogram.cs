using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static int calculate (int n1,int n2,char op)
        {
            int r1=0;
            switch (op)
            {
                case '+':
                    r1 = n1 + n2;
                    break;
                case '-':
                    r1 = n1 - n2;
                    break;
                case '*':
                    r1 = n1 * n2;
                    break;
                case '/':
                    r1 = n1 / n2;
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            return (r1);
        }
        static void Main(string[] args)
        {
            int num1, num2;
            char opr;
            Console.Write("Enter Number 1 = ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2 = ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter +,-,*,/");
            opr = Convert.ToChar(Console.ReadLine());
            int res = calculate(num1, num2, opr);
            Console.WriteLine("{0} {1} {2} = {3}", num1, opr, num2,res);
            Console.ReadKey();
        }

    }
}
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
            int counter,marks,sum=0;
            float per;
            Console.WriteLine("Enter marks of 5 subjects =");
            for (counter=1;counter<=5;counter++) {
                Console.Write("Enter marks of subject {0} =", counter);
                marks=Convert.ToInt32(Console.ReadLine());
                sum+=marks;
                }
            per = (sum / 500.0f) * 100.0f;
            Console.WriteLine("Total marks = {0}", sum);
            Console.WriteLine("Percentage = {0}", per);
            if (per >= 75)
            {
                Console.WriteLine("Grade = A+");
            }
            else if (per >=60 && per<75)
            {
                Console.WriteLine("Grade = A");
            }
            else if (per >= 50 && per < 60)
            {
                Console.WriteLine("Grade = B");
            }
            else if (per >= 40 && per < 50)
            {
                Console.WriteLine("Grade = C");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.ReadKey();
        }

    }
}
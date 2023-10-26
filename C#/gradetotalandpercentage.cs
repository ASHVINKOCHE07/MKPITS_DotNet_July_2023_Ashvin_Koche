using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            int[]sub=new int[5];
            int total=0;
            float percentage;
            string grade;
            for (int cnt=0;cnt<5;cnt++) {
                Console.Write("Enter marks of subject {0}:",cnt+1);
                sub[cnt] = Convert.ToInt32(Console.ReadLine());
                total = total + sub[cnt];
            }
            percentage = (total /500f)*100f;
            Console.WriteLine("Total marks = {0}", total);
            Console.WriteLine("Percentage = {0} % ", percentage);
            if (percentage > 75)
            {
                grade = "A+";
                Console.WriteLine("grade = " + grade);
            }else if(percentage<75 && percentage>=60)
            {
                grade = "B";
                Console.WriteLine("grade = " + grade);
            }
            else if (percentage < 60 && percentage >= 50)
            {
                grade = "C";
                Console.WriteLine("grade = " + grade);
            }
            else if (percentage < 50 && percentage >= 40)
            {
                grade = "D";
                Console.WriteLine("grade = " + grade);
            }
            else
            {
                Console.WriteLine("Failed better luck next time....");
            }
            Console.ReadKey();
        }

    }
}
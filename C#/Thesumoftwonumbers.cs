using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = Sum(num1, num2);
        Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }
}
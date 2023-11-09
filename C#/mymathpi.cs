using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp173
{
    public static class myMath
    {
        public static float PI = 3.314f;
        public static int cube(int n) { return n * n * n; }
    }
    internal class TestMyMath
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Value of PI is : "+myMath.PI);
           Console.WriteLine("Cube of 3 is : " + myMath.cube(3));
        }
    }
}

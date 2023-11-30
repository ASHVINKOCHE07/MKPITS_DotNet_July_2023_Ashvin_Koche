using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp240
{
   internal class Program
    {
        static void Main(string[] args)
        {
            string std = null;
            try
            {
                Console.WriteLine(std.Substring(5));
            }
            catch (Exception er)
            {
                Console.WriteLine(er.ToString());
                Console.WriteLine("catch block executed.");
            }
            finally
            {
                Console.WriteLine("finally block executed");
            } 
            Console.ReadKey();
        }
    }
}

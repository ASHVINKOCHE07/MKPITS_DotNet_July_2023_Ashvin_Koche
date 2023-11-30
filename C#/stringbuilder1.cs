using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp241
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Amish");
            sb.Append("Anil");
            Console.WriteLine("strig builder contains : "+sb.ToString());
            Object obj = sb;
            Console.WriteLine(obj.ToString());
            try
            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.ToString());    
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}

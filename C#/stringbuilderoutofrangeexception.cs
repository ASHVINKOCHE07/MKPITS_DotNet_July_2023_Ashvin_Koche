using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp242
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name="Ashvin";
            String subject = "mathematics";
            Console.WriteLine(name.Length);
            StringBuilder sr = new StringBuilder(name.Length,name.Length); 
            try
            {
                sr.Append(subject);
            }
            catch (Exception rt)
            {
                Console.WriteLine(rt.ToString());
            }
            Console.WriteLine("End of Program.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp233
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            li.Add("c#");
WindowsFormsApp6            li.Add("c++");
            li.Add("c");
            li.Add("java");
            li.Add("ASP.net");
            Console.WriteLine(li.Contains("c#"));
            Console.WriteLine(li[0]);
            Console.WriteLine(li[1]);
            li.Remove("c#");
            li.Remove("java");
            Console.WriteLine(li.Contains("c#"));
            li.Insert(0, "oracle");
            Console.WriteLine("After  remove and insert method : ");
            foreach (string s in li) 
            {
                Console.WriteLine(s); 
            }
            li.Sort();
            Console.WriteLine("After sort method : ");
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}

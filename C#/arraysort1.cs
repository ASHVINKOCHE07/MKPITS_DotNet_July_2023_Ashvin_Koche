using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp221
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(19);
            ar.Add(12);
            ar.Add(13);
            Console.WriteLine("array list collection without sorting");
            foreach (int obj in ar)
            {
                Console.WriteLine("Student rno : "+obj);
            }
            ar.Sort();
            Console.WriteLine("array list collection with sorting");
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno : " + obj);
            }
        }
    }
}

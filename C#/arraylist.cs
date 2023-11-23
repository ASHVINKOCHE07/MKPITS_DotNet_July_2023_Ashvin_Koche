using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp220
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(11);
            ar.Add(12);
            ar.Add(13);
            ar.Add(14);
            foreach(int i in ar) 
            {
                Console.WriteLine("Student Rno"+i);
            }
            Console.WriteLine("Capacity : {0} ", ar.Capacity);
            Console.WriteLine("Count : {0} ",ar.Count);
        }
    }
}

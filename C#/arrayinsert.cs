using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList(); 
            ar.Add(19);
            ar.Add(10);
            ar.Add(1);
            Console.WriteLine("array collection without sorting");
            foreach (int obj in ar)
            {
                Console.WriteLine("Student rno :"+obj);
            }
            ar.Insert(2, 17);
            Console.WriteLine("array list collection after adding element at 2 position.");
            foreach (int obj in ar)
            {
                Console.WriteLine("Student rno : "+obj);
            }
        }
    }
}

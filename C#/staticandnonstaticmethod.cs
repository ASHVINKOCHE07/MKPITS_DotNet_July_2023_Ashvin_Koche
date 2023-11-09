using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp170
{
    class Student
    {
        public static void display()
        {
            Console.WriteLine("hello");

        }
        public void sayhi()
        {
            Console.WriteLine("hi");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student.display();
            Student s = new Student();
            s.sayhi();
        }
    }
}

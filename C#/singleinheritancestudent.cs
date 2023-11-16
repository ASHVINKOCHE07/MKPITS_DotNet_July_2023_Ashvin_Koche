using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp175
{
    class Person
    {
        public string name;
    }
    class Student : Person
    {
        public int rno;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.rno = 111;
            s.name = "Ashvin";
            Console.WriteLine("Roll No : "+s.rno);
            Console.WriteLine("Name : "+s.name);
        }
    }
}

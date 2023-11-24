using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp216
{
    class Student
    {
        internal int rno;
        internal String name;
        public void displaydata()
        {
            Console.WriteLine("Rno : "+rno);
            Console.WriteLine("Rno : " +name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s= new Student();
            s.rno = 2;
            s.name = "rajesh";
            s.displaydata();
        }
    }
}

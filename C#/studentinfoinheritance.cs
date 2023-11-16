using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp178
{
    public class Person
    {
        public String name;
        public String address;
    }
    public class Student : Person
    {
        public int rno;
        public int marks;
    }
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            Student s1= new Student();

            s1.rno = 123;
            s1.name = "Ashvin";
            s1.address = "Pune";
            s1.marks = 850;
            Console.WriteLine("1.R.no = "+s1.rno);
            Console.WriteLine("2.Name = " + s1.name);
            Console.WriteLine("3.Address = " + s1.address);
            Console.WriteLine("4.Marks = " + s1.marks);
        }
    }
}

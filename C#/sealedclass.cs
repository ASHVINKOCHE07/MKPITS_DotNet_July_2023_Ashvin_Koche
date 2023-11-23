using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp212
{
    abstract class Person
    {
        public String name;
    }
    class Student : Person
    {
        public int rno;
    }
    sealed class  parttimestudent:Student
    {
        public int hours;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            parttimestudent p = new parttimestudent();
            p.rno = 22;
            p.name = "Ravi";
            p.hours =6;
            Console.WriteLine("rno " + p.rno);
            Console.WriteLine("name " + p.name);
            Console.WriteLine("hours " + p.hours);
            Console.ReadKey();
        }
    }
}

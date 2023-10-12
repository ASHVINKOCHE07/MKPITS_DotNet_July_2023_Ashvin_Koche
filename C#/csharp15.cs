using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp15
{
    class Class1
    {
        struct student
        {
            public int rno;
            public string name;
            public string course;
        }
        public static void Main()
        {
            student s1;
            s1.rno = 123;
            s1.name = "Ashvin";
            s1.course = "Dotnet";
            Console.WriteLine("1.rno = " + s1.rno);
            Console.WriteLine("2.name = " + s1.name);
            Console.WriteLine("3.course = " + s1.course);
        }
    }
}

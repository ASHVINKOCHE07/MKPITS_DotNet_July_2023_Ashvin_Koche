using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsileApp16
{
    class Class1
    {
        public int rno;
        public string name;
        public string  course;
    }
    public static void Main()
    {
        student s1;
        Console.WriteLine("Enter rno ");
        s1.rno = Convert.ToInt32(Console.ReadLine());
        s1.name = Console.ReadLine();
        s1.course = Console.ReadLine();
        Console.WriteLine("rno " + s1.rno);
        Console.WriteLine("name " + s1.name);
        Console.WriteLine("course " + s1.course);
    }
}
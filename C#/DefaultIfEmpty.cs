/*
 *  C# Program to Demonstrate DefaultIfEmpty case
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace program
{
    class student
    {
        public string Name { get; set; }
        public string stuID { get; set; }
 
    }
    class studentdetails
    {
        public string SID { get; set; }
        public string City { get; set; }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            List<student> objstudent = new List<student>{
                new student{ Name="Bob",stuID="I001"},
                new student{ Name="Vijay",stuID="I002"},
                new student{ Name="Jerry",stuID="I003"},
                new student{ Name="Tom",stuID="I004"},
                new student{ Name="Senthil",stuID="I005"},
            };
            List<studentdetails> objstudentdetails = new List<studentdetails>{
                new studentdetails{ SID="I001",City="Delhi"},
                new studentdetails{ SID="I002",City="Mumbai"},
                new studentdetails{ SID="I007",City="Chennai"},
                new studentdetails{ SID="I008",City="Pune"},
                new studentdetails{ SID="I009",City=""},
            };
            var resultDefaultIfEmpty = from stu in objstudent
                                       join studentdetails in objstudentdetails 
                                       on stu.stuID equals studentdetails.SID 
                                       into ResultEmpstudentdetails
 
             from output in ResultEmpstudentdetails.DefaultIfEmpty()
             select new
             {
                    studentName = stu.Name,
                    City = output != null ? output.City : null
             };
            Console.WriteLine(string.Join("\n", resultDefaultIfEmpty.Select(stu => 
                        " student Name = " +  stu.studentName + ", City Name = " + 
                        stu.City).ToArray<string>()));
            Console.ReadLine();
       }
    }
}
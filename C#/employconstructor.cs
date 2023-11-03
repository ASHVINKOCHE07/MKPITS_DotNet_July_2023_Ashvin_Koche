using System;

namespace EmployeeClass
{
    class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            EmpNo = 123;
            EmpName = "Amit Mishra";
            Designation = "Software Engineer";
            Salary = 60000;
        }

        public void Display()
        {
            Console.WriteLine("EmpNo: " + EmpNo);
            Console.WriteLine("EmpName: " + EmpName);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Salary: " + Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Display();
        }
    }
}
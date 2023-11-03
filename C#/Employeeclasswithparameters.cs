using System;

namespace EmployeeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class with no parameters
            Employee emp1 = new Employee();
            emp1.EmpNo = 101;
            emp1.EmpName = "Arun Raj";
            emp1.Designation = "Software Engineer";
            emp1.Salary = 50000;
            Console.WriteLine("Employee 1:");
            Console.WriteLine("Emp No: {0}", emp1.EmpNo);
            Console.WriteLine("Emp Name: {0}", emp1.EmpName);
            Console.WriteLine("Designation: {0}", emp1.Designation);
            Console.WriteLine("Salary: {0}", emp1.Salary);

            // Create an instance of the Employee class with parameters
            Employee emp2 = new Employee(202, "Suraj Kumar", "Project Manager", 70000);
            Console.WriteLine("Employee 2:");
            Console.WriteLine("Emp No: {0}", emp2.EmpNo);
            Console.WriteLine("Emp Name: {0}", emp2.EmpName);
            Console.WriteLine("Designation: {0}", emp2.Designation);
            Console.WriteLine("Salary: {0}", emp2.Salary);
        }
    }

    class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }

        // Constructor with no parameters
        public Employee()
        {
            EmpNo = 0;
            EmpName = "";
            Designation = "";
            Salary = 0.0;
        }

        // Constructor with four parameters
        public Employee(int empNo, string empName, string designation, double salary)
        {
            EmpNo = empNo;
            EmpName = empName;
            Designation = designation;
            Salary = salary;
        }
    }
}
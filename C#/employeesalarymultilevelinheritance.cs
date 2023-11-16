using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PersonExample
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }

    class Employee : Person
    {
        public int EmpNo { get; set; }
        public double Salary { get; set; }
        public string Designation { get; set; }

        public Employee(string name, string address, int empNo, double salary, string designation) : base(name, address)
        {
            EmpNo = empNo;
            Salary = salary;
            Designation = designation;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new employee
            Employee emp = new Employee("John Doe", "123 Main St", 12345, 50000.0, "Software Engineer");

            // Print the employee's information
            Console.WriteLine("Name: " + emp.Name);
            Console.WriteLine("Address: " + emp.Address);
            Console.WriteLine("Emp No: " + emp.EmpNo);
            Console.WriteLine("Salary: " + emp.Salary);
            Console.WriteLine("Designation: " + emp.Designation);
        }
    }
}

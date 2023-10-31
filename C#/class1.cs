using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the Employee class
            class Employee
            {
                public string Name { get; set; }
                public int EmployeeID { get; set; }
                public double Salary { get; set; }
            }

            // Input the number of employees
            int numEmployees = int.Parse(Console.ReadLine());

            // Create an array of Employee objects
            Employee[] employees = new Employee[numEmployees];

            // Input the details of each employee
            for (int cnt = 0; cnt < numEmployees; cnt++)
            {
                Console.WriteLine("Enter details for employee " + (cnt + 1) + ":");
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Employee ID:");
                int employeeID = int.Parse(Console.ReadLine());
                Console.WriteLine("Salary:");
                double salary = double.Parse(Console.ReadLine());

                // Create a new Employee object and add it to the array
                Employee employee = new Employee();
                employee.Name = name;
                employee.EmployeeID = employeeID;
                employee.Salary = salary;
                employees[cnt] = employee;
            }

            // Find the employee with the highest salary
            Employee highestSalaryEmployee = employees[0];
            for (int cnt = 1; cnt < numEmployees; cnt++)
            {
                if (employees[cnt].Salary > highestSalaryEmployee.Salary)
                {
                    highestSalaryEmployee = employees[cnt];
                }
            }

            // Display the details of the employee with the highest salary
            Console.WriteLine("The employee with the highest salary is:");
            Console.WriteLine("Name: " + highestSalaryEmployee.Name);
            Console.WriteLine("Employee ID: " + highestSalaryEmployee.EmployeeID);
            Console.WriteLine("Salary: " + Convert.ToString(highestSalaryEmployee.Salary));
        }
    }
}
using System;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a Student class with properties for Name, RollNumber, and an array to store SubjectMarks
            class Student
            {
                public string Name { get; set; }
                public int RollNumber { get; set; }
                public int[] SubjectMarks { get; set; }

                public double AverageMarks { get { return Convert.ToDouble(CalculateAverage()); } }

                public string CalculateAverage()
                {
                    int sum = 0;
                    for (int cnt = 0; cnt < SubjectMarks.Length; cnt++)
                    {
                        sum += SubjectMarks[cnt];
                    }
                    return sum / SubjectMarks.Length;
                }
            }

            // Create an instance of the Student class, set values for these properties, and calculate the average marks of the student using only the Convert.To method
            Student student = new Student();
            student.Name = "John Doe";
            student.RollNumber = 12345;
            student.SubjectMarks = new int[] { 80, 90, 85, 95 };

            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Roll Number: " + student.RollNumber);
            Console.WriteLine("Average Marks: " + student.AverageMarks);

            Console.ReadLine();
        }
    }
}using System;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a Student class with properties for Name, RollNumber, and an array to store SubjectMarks
            class Student
            {
                public string Name { get; set; }
                public int RollNumber { get; set; }
                public int[] SubjectMarks { get; set; }

                public double AverageMarks { get { return Convert.ToDouble(CalculateAverage()); } }

                public string CalculateAverage()
                {
                    int sum = 0;
                    for (int cnt = 0; cnt < SubjectMarks.Length; cnt++)
                    {
                        sum += SubjectMarks[cnt];
                    }
                    return sum / SubjectMarks.Length;
                }
            }

            // Create an instance of the Student class, set values for these properties, and calculate the average marks of the student using only the Convert.To method
            Student student = new Student();
            student.Name = "John Doe";
            student.RollNumber = 12345;
            student.SubjectMarks = new int[] { 80, 90, 85, 95 };

            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Roll Number: " + student.RollNumber);
            Console.WriteLine("Average Marks: " + student.AverageMarks);

            Console.ReadLine();
        }
    }
}
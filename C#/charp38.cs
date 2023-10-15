using System;

class GradeDescription
{
    static void Main(string[] args)
    {
        char grade;

        Console.Write("Enter a grade (E, V, G, A, or F): ");
        grade = char.Parse(Console.ReadLine());

        if (grade == 'E')
        {
            Console.WriteLine("Grade: Excellent");
        }
        else if (grade == 'V')
        {
            Console.WriteLine("Grade: Very Good");
        }
        else if (grade == 'G')
        {
            Console.WriteLine("Grade: Good");
        }
        else if (grade == 'A')
        {
            Console.WriteLine("Grade: Average");
        }
        else if (grade == 'F')
        {
            Console.WriteLine("Grade: Fail");
        }
        else
        {
            Console.WriteLine("Invalid grade entered.");
        }
    }
}
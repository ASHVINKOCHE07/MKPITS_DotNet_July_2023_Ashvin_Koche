using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter month number: ");
        int monthNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        int numberOfDays;

        if (monthNumber == 2)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                numberOfDays = 29;
            }
            else
            {
                numberOfDays = 28;
            }
        }
        else if (monthNumber == 4 || monthNumber == 6 || monthNumber == 9 || monthNumber == 11)
        {
            numberOfDays = 30;
        }
        else
        {
            numberOfDays = 31;
        }

        Console.WriteLine("Number of days in month {0} of year {1} is {2}", monthNumber, year, numberOfDays);
    }
}
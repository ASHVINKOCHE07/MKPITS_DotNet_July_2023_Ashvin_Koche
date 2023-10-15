using System;

class Program
{
    static void Main(string[] args)
    {
        int dayNumber;
        string dayName;

        Console.Write("Enter a day number (1-7): ");
        dayNumber = int.Parse(Console.ReadLine());

        switch (dayNumber)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saturday";
                break;
            case 7:
                dayName = "Sunday";
                break;
            default:
                dayName = "Invalid day number";
                break;
        }

        Console.WriteLine("The day name is: " + dayName);
    }
}

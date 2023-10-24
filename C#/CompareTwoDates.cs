using System;

class CompareDates {
    static void Main(string[] args) {
        DateTime date1 = new DateTime(2021, 8, 1); // first date
        DateTime date2 = new DateTime(2021, 8, 2); // second date

        if (date1 == date2) {
            Console.WriteLine("The two dates are equal.");
        } else if (date1 > date2) {
            Console.WriteLine("date1 is later than date2.");
        } else {
            Console.WriteLine("date2 is later than date1.");
        }
    }
}
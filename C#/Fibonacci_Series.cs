using System;

class FibonacciSeries {
    static void Main(string[] args) {
        int count1 = 10; // number of terms in the series
        int firstTerm = 0, secondTerm = 1;

        Console.Write("Fibonacci Series: ");

        for (int count2 = 1; count2 <= count1; count2++) {
            int nextTerm = firstTerm + secondTerm;
            Console.Write(nextTerm + " ");
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }
    }
}
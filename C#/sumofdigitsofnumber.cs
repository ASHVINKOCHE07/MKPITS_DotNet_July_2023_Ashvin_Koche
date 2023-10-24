using System;

class SumOfDigits {
    static void Main(string[] args) {
        int n = 1234; // number whose sum of digits is to be found
        int sum = 0;

        Console.Write("Sum of digits of " + n + " is: ");

        while (n > 0) {
            int digit = n % 10;
            sum += digit;
            n /= 10;
        }

        Console.WriteLine(sum);
    }
}
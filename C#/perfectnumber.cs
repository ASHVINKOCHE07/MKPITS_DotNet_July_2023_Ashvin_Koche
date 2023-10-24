using System;

class PerfectNumber {
    static void Main(string[] args) {
        int n = 6; // number to be checked

        int sum = 0;
        for (int count = 1; count < n; count++) {
            if (n % count == 0) {
                sum += count;
            }
        }

        if (sum == n) {
            Console.WriteLine(n + " is a perfect number.");
        } else {
            Console.WriteLine(n + " is not a perfect number.");
        }
    }
}
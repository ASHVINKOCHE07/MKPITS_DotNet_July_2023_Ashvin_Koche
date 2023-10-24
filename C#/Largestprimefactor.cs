using System;

class LargestPrimeFactor {
    static void Main(string[] args) {
        int n = 12; // number whose largest prime factor is to be found
        int largestPrimeFactor = 0;
        int count1 = 2, count2 = 0;

        Console.Write("Largest Prime Factor of " + n + " is: ");

        while (count1 <= n) {
            while (n % count1 == 0) {
                largestPrimeFactor = count1;
                n /= count1;
            }
            count1++;
        }

        Console.WriteLine(largestPrimeFactor);
    }
}
using System;

class Program {
    static void Main(string[] args) {
        int[] numbers = new int[10];
        int[] oddNumbers = new int[5];
        int[] evenNumbers = new int[5];

        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++) {
            if (numbers[i] % 2 == 0) {
                evenNumbers[i % 5] = numbers[i];
            } else {
                oddNumbers[i % 5] = numbers[i];
            }
        }

        Console.WriteLine("Odd numbers:");
        for (int i = 0; i < oddNumbers.Length; i++) {
            Console.WriteLine(oddNumbers[i]);
        }

        Console.WriteLine("Even numbers:");
        for (int i = 0; i < evenNumbers.Length; i++) {
            Console.WriteLine(evenNumbers[i]);
        }
    }
}
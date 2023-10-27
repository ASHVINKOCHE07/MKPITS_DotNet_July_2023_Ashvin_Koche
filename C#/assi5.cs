using System;

class Program {
    static void Main(string[] args) {
        int[] arr = new int[10];
        int n = arr.Length;
        int[] freq = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++) {
            string input = Console.ReadLine();
            arr[i] = Convert.ToInt32(input);
        }

        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                if (arr[i] == arr[j]) {
                    freq[i]++;
                }
            }
        }

        Console.WriteLine("Frequency of each element:");
        for (int i = 0; i < n; i++) {
            Console.WriteLine(arr[i] + ": " + freq[i]);
        }
    }
}
using System;

class Program {
    static void Main(string[] args) {
        int[] arr = new int[5];
        int max = int.MinValue;
        int min = int.MaxValue;

        Console.WriteLine("Enter 5 integers:");

        for (int i = 0; i < arr.Length; i++) {
            string input = Console.ReadLine();
            arr[i] = Convert.ToInt32(input);

            if (arr[i] > max) {
                max = arr[i];
            }

            if (arr[i] < min) {
                min = arr[i];
            }
        }

        Console.WriteLine("Maximum element: " + max);
        Console.WriteLine("Minimum element: " + min);
    }
}
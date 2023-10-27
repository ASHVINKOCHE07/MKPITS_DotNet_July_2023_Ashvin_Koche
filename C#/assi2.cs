using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter the number of values to read: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the values:");
        for (int cnt = 0; cnt < n; cnt++) {
            arr[cnt] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Values in reverse order:");
        for (int cnt = n - 1; cnt >= 0; cnt--) {
            Console.Write(arr[cnt] + " ");
        }
    }
}
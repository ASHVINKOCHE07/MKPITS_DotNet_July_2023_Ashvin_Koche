using System;

class Program {
    static void Main(string[] args) {
        int[] arr1 = new int[5];
        int[] arr2 = new int[5];

        Console.WriteLine("Enter 5 integers:");
        for (int cnt = 0; cnt < arr1.Length; cnt++) {
            arr1[cnt] = int.Parse(Console.ReadLine());
        }

        for (int cnt = 0; cnt < arr1.Length; cnt++) {
            arr2[cnt] = arr1[cnt];
        }

        Console.WriteLine("Array 1:");
        for (int cnt = 0; cnt < arr1.Length; cnt++) {
            Console.Write(arr1[cnt] + " ");
        }

        Console.WriteLine("\nArray 2:");
        for (int cnt = 0; cnt < arr2.Length; cnt++) {
            Console.Write(arr2[cnt] + " ");
        }
    }
}
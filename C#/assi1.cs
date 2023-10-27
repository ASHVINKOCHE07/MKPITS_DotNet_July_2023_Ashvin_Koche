using System;

class Program {
    static void Main(string[] args) {
        int[] numbers = new int[5];
        int cnt = 0;

        for (int cnt = 0; cnt < numbers.Length; cnt++) {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            numbers[cnt] = Convert.ToInt32(input);
        }

        Console.WriteLine("The numbers you entered are:");
        for (int cnt = 0; cnt < numbers.Length; cnt++) {
            Console.WriteLine(numbers[cnt]);
        }
    }
}
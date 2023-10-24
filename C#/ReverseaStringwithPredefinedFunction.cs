using System;

class ReverseString {
    static string Reverse(string str) {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main(string[] args) {
        string str = "Hello, World!";
        string reversedStr = Reverse(str);

        Console.WriteLine("Original String: " + str);
        Console.WriteLine("Reversed String: " + reversedStr);
    }
}
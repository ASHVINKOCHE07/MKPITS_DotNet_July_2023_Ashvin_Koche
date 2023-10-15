using System;

class Program
{
    static void Main(string[] args)
    {
        char ch;

        Console.Write("Enter an alphabet: ");
        ch = Convert.ToChar(Console.ReadLine());

        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
        {
            Console.WriteLine("{0} is a vowel", ch);
        }
        else
        {
            Console.WriteLine("{0} is a consonant", ch);
        }
    }
}
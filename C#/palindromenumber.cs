using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 121;
            int revNum = 0;
            int temp = num;
            while (num!= 0)
            {
                revNum = revNum * 10 + num % 10;
                num /= 10;
            }
            if (temp == revNum)
            {
                Console.WriteLine(temp + " is a palindrome number.");
            }
            else
            {
                Console.WriteLine(temp + " is not a palindrome number.");
            }
        }
    }
}
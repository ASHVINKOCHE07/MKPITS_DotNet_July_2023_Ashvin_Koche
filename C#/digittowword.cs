using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 1234;
        string word = "";

        if (num == 0)
        {
            word = "Zero";
        }
        else
        {
            while (num > 0)
            {
                if (num % 1000!= 0)
                {
                    if (num % 100 == 0)
                    {
                        word = GetTens(num % 100) + " " + word;
                    }
                    else if (num % 10 == 0)
                    {
                        word = GetDigit(num % 100) + " " + word;
                    }
                    else
                    {
                        word = GetDigit(num % 10) + " " + GetTens(num % 100) + " " + word;
                    }
                }
                num /= 1000;
            }
        }

        Console.WriteLine(word.Trim());
    }

    static string GetDigit(int num)
    {
        switch (num)
        {
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            default:
                return "";
        }
    }

    static string GetTens(int num)
    {
        switch (num)
        {
            case 10:
                return "Ten";
            case 11:
                return "Eleven";
            case 12:
                return "Twelve";
            case 13:
                return "Thirteen";
            case 14:
                return "Fourteen";
            case 15:
                return "Fifteen";
            case 16:
                return "Sixteen";
            case 17:
                return "Seventeen";
            case 18:
                return "Eighteen";
            case 19:
                return "Nineteen";
            case 20:
                return "Twenty";
            case 30:
                return "Thirty";
            case 40:
                return "Forty";
            case 50:
                return "Fifty";
            case 60:
                return "Sixty";
            case 70:
                return "Seventy";
            case 80:
                return "Eighty";
            case 90:
                return "Ninety";
            default:
                return "";
        }
    }
}
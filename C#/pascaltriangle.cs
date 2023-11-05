using System;

class PascalTriangle
{
    static void Main(string[] args)
    {
        int n = 5; // Change this to change the number of rows

        for (int cnt = 0; cnt < n; cnt++)
        {
            for (int cnt1 = 0; cnt1 <= cnt; cnt1++)
            {
                Console.Write(BinomialCoefficient(cnt, cnt1) + " ");
            }
            Console.WriteLine();
        }
    }

    static int BinomialCoefficient(int n, int k)
    {
        if (k == 0 || k == n)
        {
            return 1;
        }
        else
        {
            return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
        }
    }
}
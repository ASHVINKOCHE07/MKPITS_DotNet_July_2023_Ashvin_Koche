using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 100.0; // Amount to convert
            double fromCurrency = 1.0; // Currency to convert from
            double toCurrency = 2.0; // Currency to convert to

            // Convert from one currency to another
            double convertedAmount = ConvertCurrency(amount, fromCurrency, toCurrency);

            Console.WriteLine("Converted amount: " + convertedAmount);
        }

        static double ConvertCurrency(double amount, double fromCurrency, double toCurrency)
        {
            // Perform currency conversion logic here
            // For example, using a web service to retrieve the current exchange rate
            // and multiplying the amount by the exchange rate
            double convertedAmount = amount * fromCurrency / toCurrency;
            return convertedAmount;
        }
    }
}
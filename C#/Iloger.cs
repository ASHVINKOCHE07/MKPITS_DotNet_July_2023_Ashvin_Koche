using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface ILogger
    {
        void LogMessage(string message);
        void LogError(string errorMessage);
    }

    class ConsoleLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        public void LogError(string errorMessage)
        {
            Console.WriteLine("Error: " + errorMessage);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.LogMessage("Hello, world!");
            logger.LogError("An error occurred.");
            Console.ReadKey();
        }
    }
}
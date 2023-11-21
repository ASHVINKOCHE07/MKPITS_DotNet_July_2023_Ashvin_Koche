using System;

interface ILogger
{
    void LogError(string errorMessage);
    void LogWarning(string warningMessage);
    void LogInfo(string infoMessage);
}

class ConsoleLogger : ILogger
{
    public void LogError(string errorMessage)
    {
        Console.WriteLine($"Error: {errorMessage}");
    }

    public void LogWarning(string warningMessage)
    {
        Console.WriteLine($"Warning: {warningMessage}");
    }

    public void LogInfo(string infoMessage)
    {
        Console.WriteLine($"Info: {infoMessage}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        logger.LogError("An error occurred!");
        logger.LogWarning("A warning occurred!");
        logger.LogInfo("An informational message.");
    }
}
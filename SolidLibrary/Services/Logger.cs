using System;

namespace SolidLibrary.Services
{
    public class Logger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
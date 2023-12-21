using System;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Services
{
    public class Logger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
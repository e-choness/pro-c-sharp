using System;

namespace SolidLibrary.Services
{
    public class StandardMessager
    {
        public static void ApplicationStartMessage()
        {
            Console.WriteLine("Welcome to Game Wishlist Recorder.");
        }

        public static void ApplicationEndMessage()
        {
            Console.WriteLine("Thank you for using Game Wishlist Recorder. Press Enter to exit...");
        }

        public static void ValidateErrorMessage(string sender)
        {
            Console.WriteLine($"Failed to validate {sender}");
        }
    }
}
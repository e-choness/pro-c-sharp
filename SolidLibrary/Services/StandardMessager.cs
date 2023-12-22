using System;

namespace SolidLibrary.Services
{
    public class StandardMessager
    {
        public static void WishlistRecorderStartMessage()
        {
            Console.WriteLine("Welcome to Game Wishlist Recorder.");
        }

        public static void WishlistRecorderEndMessage()
        {
            Console.WriteLine("Thank you for using Game Wishlist Recorder. Press Enter to exit...");
        }

        public static void GameStoreStartMessage()
        {
            Console.WriteLine("Welcome to our Game Store.");
        }

        public static void GameStoreEndMessage()
        {
            Console.WriteLine("Thank you for visiting our Game Store. Press Enter to exit...");
        }

        public static void PersonnelSystemStartMessage()
        {
            Console.WriteLine("Welcome to Personnel System.");
        }

        public static void PersonnelSystemEndMessage()
        {
            Console.WriteLine("Thank you for using Personnel System. Press Enter to exit...");
        }

        public static void ValidateErrorMessage(string sender)
        {
            Console.WriteLine($"Failed to validate {sender}");
        }

        public static void SeparatorMessage()
        {
            Console.WriteLine("\n===========================================\n");
        }
    }
}
using System;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Services
{
    public class WishlistRecorder
    {
        public static void Record(IProduct game)
        {
            Console.WriteLine($"Add {game.Id} at {game.Price}$ to wishlist.");
        }
    }
}
using System;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Services
{
    public class WishlistRecorder
    {
        public static void Record(IWishlisted game)
        {
            game.IsWishlisted = true;
            Console.WriteLine($"Add {game.Id} - {game.Title}of {game.Genre} at {game.Price}$ to wishlist.");
        }
    }
}
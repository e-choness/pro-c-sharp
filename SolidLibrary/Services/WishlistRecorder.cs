using System;
using SolidLibrary.Interfaces;
using SolidLibrary.Models;

namespace SolidLibrary.Services
{
    public class WishlistRecorder
    {
        public static IWishlisted CreateWishlistedFPS(IProduct game)
        {
            return new FirstPersonShooter
            {
                Id = game.Id,
                Title = game.Title,
                Price = game.Price
            };
        }

        public static IWishlisted CreateWishlistedRPG(IProduct game)
        {
            return new RolePlayingGame
            {
                Id = game.Id,
                Title = game.Title,
                Price = game.Price
            };
        }

        public static IWishlisted CreateWishlistedRTS(IProduct game)
        {
            return new RealTimeStrategy
            {
                Id = game.Id,
                Title = game.Title,
                Price = game.Price
            };
        }

        public static IWishlisted CreateWishlistedIS(IProduct game)
        {
            return new ImmersiveSims
            {
                Id = game.Id,
                Title = game.Title,
                Price = game.Price
            };
        }
        
        public static void Record(IWishlisted game)
        {
            game.IsWishlisted = true;
            Console.WriteLine($"Add {game.Id} - {game.Title} of {game.Genre} at {game.Price}$ to wishlist.");
        }
    }
}
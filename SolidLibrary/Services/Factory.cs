using SolidLibrary.Interfaces;
using SolidLibrary.Models;

namespace SolidLibrary.Services
{
    public class Factory
    {
        public static IProduct CreateGame()
        {
            return new Game();
        }

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

        public static IVendor CreateRetailer()
        {
            return new Retailer(CreateLogger(), CreateMailer());
        }

        public static IVendor CreateAnotherRetaier()
        {
            return new Retailer(CreateLogger(), CreateTexter());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateMailer()
        {
            return new Mailer();
        }

        public static IMessageSender CreateTexter()
        {
            return new Texter();
        }
    }
}


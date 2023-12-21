using SolidLibrary.Interfaces;
using SolidLibrary.Models;
using SolidLibrary.Services;

namespace DependencyInversion;

public class Factory
{
    public static IProduct CreateGame()
    {
        return new Game();
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
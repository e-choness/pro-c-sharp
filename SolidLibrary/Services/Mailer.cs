using System;
using SolidLibrary.Models;

namespace SolidLibrary.Services
{
    public class Mailer
    {
        public void SendEmail(Game game, string message)
        {
            Console.WriteLine($"{game.Id} - {game.Title}:{game.Subtitle} message: {message}.");
        }
    }
}
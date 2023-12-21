using System;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Services
{
    public class Mailer : IMessageSender
    {
        public void SendMessage(IProduct product, string message)
        {
            Console.WriteLine($"{product.Id} is sending email: {message}.");
        }
    }
}
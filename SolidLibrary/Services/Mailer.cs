using System;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Services
{
    public class Mailer : IMessageSender
    {
        public void SendMessage(IVendor retailer, string message)
        {
            Console.WriteLine($"{retailer.Store} is sending email: {message}.");
        }
    }
}
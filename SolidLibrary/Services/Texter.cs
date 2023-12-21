using System;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Services
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IProduct product, string message)
        {
            Console.WriteLine($"{product.Id} is sending text: {message}");
        }
    }
}
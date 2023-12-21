using System;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Services
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IVendor vendor, string message)
        {
            Console.WriteLine($"{vendor.Store} is sending text: {message}");
        }
    }
}
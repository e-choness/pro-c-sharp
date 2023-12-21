using System;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Services
{
    public class Retailer : IVendor
    {
        public string Store { get; set; }
        public IProduct Game { get; set; }
        public double Revenue { get; set; }
        public bool IsSoldOut { get; set; }

        private ILogger _logger;
        private IMessageSender _messageSender;

        public Retailer(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }
        public void SellGame(double price)
        {
            Revenue += price;
            _logger.LogMessage($"{Game.Id} - {Game.Title} is sold at {price} bucks - {DateTime.Now}");
        }

        public void CompleteSale()
        {
            IsSoldOut = true;
            _logger.LogMessage($"Complete sale for {Game.Id} - {Game.Title}.");
            _messageSender.SendMessage(Game, $"{Store} of {Game.Id} - {Game.Title} is sold out. Total revenue {Revenue}");
        }
    }
}
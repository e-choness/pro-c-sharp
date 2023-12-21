using System;
using SolidLibrary.Models;

namespace SolidLibrary.Services
{
    public class Retailer
    {
        public string Store { get; set; }
        public Game Product { get; set; }
        public double Revenue { get; set; }
        public bool IsSoldOut { get; private set; }

        private Logger _logger;
        private Mailer _mailer;

        public Retailer(Logger logger, Mailer mailer)
        {
            _logger = logger;
            _mailer = mailer;
        }
        public void SellGame(double price)
        {
            Revenue += price;
            _logger.LogMessage($"{Product.Id} is sold at {price} bucks - {DateTime.Now}");
        }

        public void CompleteSale()
        {
            IsSoldOut = true;
            _logger.LogMessage($"Complete sale for {Product.Id} - {Product.Title}:{Product.Subtitle}.");
            _mailer.SendEmail(Product, $"{Store} of this game is sold out. Total revenue {Revenue}");
        }
    }
}
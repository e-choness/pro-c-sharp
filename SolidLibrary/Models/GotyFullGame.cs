using System;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Models
{
    public class GotyFullGame : Game, IGotyEdition, IPhysicalCopy, IDigitalCopy
    {
        public string ActivationKey { get; set; }
        public string Manual { get; set; }
        public string SeasonPassKey { get; set; }
        public string GadgetKey { get; set; }
        public string ActionFigureKey { get; set; }
        public string ArtBookKey { get; set; }
        public string ReceiptId { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string TransactionId { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime TransactionDate { get; set; }

        public void GetDescription()
        {
            Console.WriteLine("What a monstrosity this copy is.");
        }
    }
}
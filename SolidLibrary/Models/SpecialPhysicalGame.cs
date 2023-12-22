using System;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Models
{
    public class SpecialPhysicalGame : Game, IPhysicalCopy, ISpecialEdition
    {
        public string ReceiptId { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string ActivationKey { get; set; }
        public string Manual { get; set; }
        public string SeasonPassKey { get; set; }
        public string GadgetKey { get; set; }
    }
}
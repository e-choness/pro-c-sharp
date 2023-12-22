using System;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Models
{
    public class StandardDigitalGame : Game, IStandardEdition, IDigitalCopy
    {
        public string ActivationKey { get; set; }
        public string Manual { get; set; }
        public string TransactionId { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
using System;

namespace SolidLibrary.Interfaces
{
    public interface IDigitalCopy
    {
        string TransactionId { get; set; }
        string CustomerEmail { get; set; }
        DateTime TransactionDate { get; set; }
    }
}
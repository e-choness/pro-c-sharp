using System;

namespace SolidLibrary.Interfaces
{
    public interface IPhysicalCopy
    {
        string ReceiptId { get; set; }
        string CustomerPhone { get; set; }
        DateTime PurchaseDate { get; set; }
    }
}
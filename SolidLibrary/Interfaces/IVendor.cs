namespace SolidLibrary.Interfaces
{
    public interface IVendor
    {
        string Store { get; set; }
        IProduct Game { get; set; }
        double Revenue { get; set; }
        bool IsSoldOut { get; set; }
    }
}
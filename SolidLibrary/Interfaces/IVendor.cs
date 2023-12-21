namespace SolidLibrary.Interfaces
{
    public interface IVendor
    {
        string Store { get; set; }
        IProduct Game { get; set; }
        double Revenue
        {
            get => Revenue;
            set => Revenue = value;
        }
        bool IsSoldOut { get; set; }
    }
}
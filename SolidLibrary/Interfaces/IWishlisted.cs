namespace SolidLibrary.Interfaces
{
    public interface IWishlisted
    {
        string Id { get; set; }
        string Title { get; set; }
        float Price { get; set; }
        string Genre { get; set; }
        bool IsWishlisted { get; set; }
    }
}
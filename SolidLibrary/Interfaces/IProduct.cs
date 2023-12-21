namespace SolidLibrary.Interfaces
{
    public interface IProduct
    {
        string Id { get; set; }
        string Title { get; set; }
        float Price { get; set; }
    }
}
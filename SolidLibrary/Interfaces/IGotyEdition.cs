namespace SolidLibrary.Interfaces
{
    public interface IGotyEdition : ISpecialEdition
    {
        string ActionFigureKey { get; set; }
        string ArtBookKey { get; set; }
    }
}
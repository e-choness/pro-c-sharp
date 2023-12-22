namespace SolidLibrary.Interfaces
{
    public interface ISpecialEdition : IStandardEdition
    {
        string SeasonPassKey { get; set; }
        string GadgetKey { get; set; }
    }
}
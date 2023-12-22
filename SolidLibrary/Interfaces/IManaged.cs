namespace SolidLibrary.Interfaces
{
    public interface IManaged
    {
        IManager Manager { get; set; }
        void AssignManager(IManager manager);
    }
}
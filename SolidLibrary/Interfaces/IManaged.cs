namespace SolidLibrary.Interfaces
{
    public interface IManaged
    {
        string Manager { get; set; }
        
        void AssignManager(IManager manager);
    }
}
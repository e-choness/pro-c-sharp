using SolidLibrary.Interfaces;

namespace SolidLibrary.Models
{
    public class Receptionist : Personnel, IManaged
    {
        public IManager Manager { get; set; }
        
        public void AssignManager(IManager manager)
        {
            Manager = manager;
        }
    }
}
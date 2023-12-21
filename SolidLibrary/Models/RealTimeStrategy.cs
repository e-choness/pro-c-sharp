using SolidLibrary.Interfaces;

namespace SolidLibrary.Models
{
    public class RealTimeStrategy : IWishlisted
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public string Genre { get; set; } = "Real Time Strategy";
        public bool IsWishlisted { get; set; } = false;
    }
}
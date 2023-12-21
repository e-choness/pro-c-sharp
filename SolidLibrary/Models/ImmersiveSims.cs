using SolidLibrary.Interfaces;

namespace SolidLibrary.Models
{
    public class ImmersiveSims : IWishlisted
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public string Genre { get; set; } = "Immersive Sims";
        public bool IsWishlisted { get; set; } = false;
    }
}
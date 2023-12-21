using SolidLibrary.Interfaces;

namespace SolidLibrary.Models
{
    public class FirstPersonShooter : IWishlisted
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public string Genre { get; set; } = "First Person Shooter";
        public bool IsWishlisted { get; set; } = false;
    }
}
using SolidLibrary.Interfaces;

namespace SolidLibrary.Models
{
    public class RolePlayingGame : IWishlisted
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public string Genre { get; set; } = "Role Playing Game";
        public bool IsWishlisted { get; set; } = false;
    }
}
using SolidLibrary.Interfaces;

namespace SolidLibrary.Models
{
    public class Game : IProduct
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public float Price { get; set; }
    }
}
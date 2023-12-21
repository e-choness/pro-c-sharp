using SolidLibrary.Interfaces;

namespace SolidLibrary.Services
{
    public class GameValidator
    {
        public static bool Validate(IProduct game)
        {
            if (string.IsNullOrWhiteSpace(game.Id))
            {
                StandardMessager.ValidateErrorMessage($"Game Id: {game.Id} Titel: {game.Title}");
                return false;
            }

            if (game.Price < 0.0f)
            {
                StandardMessager.ValidateErrorMessage($"Game price: {game.Price} dollars");
                return false;
            }
            
            return true;
        }
    }
}
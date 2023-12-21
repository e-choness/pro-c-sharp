using SolidLibrary.Interfaces;

namespace SolidLibrary.Services
{
    public class GameValidator
    {
        public static bool Validate(IProduct game)
        {
            if (string.IsNullOrWhiteSpace(game.Id))
            {
                StandardMessage.ValidateErrorMessage($"Game Id: {game.Id}");
                return false;
            }

            if (game.Price < 0.0f)
            {
                StandardMessage.ValidateErrorMessage($"Game price: {game.Price} dollars");
                return false;
            }
            
            return true;
        }
    }
}
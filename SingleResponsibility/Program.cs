using SolidLibrary.Models;
using SolidLibrary.Services;

StandardMessage.ApplicationStartMessage();

Game game = (Game)Factory.CreateGame();
game.Id = "0002";
game.Title = "Baldur's Gate 3";
game.Subtitle = "";
game.Price = 70.00f;

if (!GameValidator.Validate(game))
{
    StandardMessage.ApplicationEndMessage();
    return -1;
}

WishlistRecorder.Record(game);

StandardMessage.ApplicationEndMessage();

return 0;


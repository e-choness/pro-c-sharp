using SolidLibrary.Models;
using SolidLibrary.Services;

StandardMessager.ApplicationStartMessage();

Game game = (Game)Factory.CreateGame();
game.Id = "0002";
game.Title = "Baldur's Gate 3";
game.Subtitle = "";
game.Price = 70.00f;

if (!GameValidator.Validate(game))
{
    StandardMessager.ApplicationEndMessage();
    return -1;
}

WishlistRecorder.Record(game);

StandardMessager.ApplicationEndMessage();

return 0;


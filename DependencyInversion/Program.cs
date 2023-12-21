using SolidLibrary.Models;
using SolidLibrary.Services;

// Start game store with welcome message
StandardMessager.GameStoreStartMessage();

// Create a game called Starfield
Game game = (Game)Factory.CreateGame();
game.Id = "0001";
game.Title = "Starfield";
game.Subtitle = "";
game.Price = 70.0f;

// Create a retailer called Steam, which is sending emails for reporting revenue
Retailer emailRetailer = (Retailer)Factory.CreateRetailer();
emailRetailer.Store = "Steam";
emailRetailer.Game = game;
emailRetailer.Revenue = 0;
emailRetailer.IsSoldOut = false;

// Create a retailer called Xbox, which is sending texts for reporting revenue
Retailer textRetailer = (Retailer)Factory.CreateAnotherRetaier();
textRetailer.Store = "Xbox";
textRetailer.Game = game;
textRetailer.Revenue = 0;
textRetailer.IsSoldOut = false;

StandardMessager.SeparatorMessage();

// Steam's sales operations
emailRetailer.SellGame(game.Price);
emailRetailer.SellGame(game.Price * 0.8f);
emailRetailer.SellGame(game.Price * 0.5f);
emailRetailer.CompleteSale();

StandardMessager.SeparatorMessage();

// Xbox's sales operations
textRetailer.SellGame(game.Price * 1.1f);
textRetailer.SellGame(game.Price);
textRetailer.CompleteSale();

StandardMessager.SeparatorMessage();

// Exit game store with end application message
StandardMessager.GameStoreEndMessage();
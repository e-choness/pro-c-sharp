using DependencyInversion;
using SolidLibrary.Models;
using SolidLibrary.Services;

// Create a game called Starfield
Game game = (Game)Factory.CreateGame();
game.Id = 0;
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

// Steam's sales operations
emailRetailer.SellGame(game.Price);
emailRetailer.SellGame(game.Price * 0.8);
emailRetailer.CompleteSale();

// Xbox's sales operations
textRetailer.SellGame(game.Price * 1.1);
textRetailer.SellGame(game.Price);
textRetailer.CompleteSale();
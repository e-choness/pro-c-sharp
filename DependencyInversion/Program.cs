using DependencyInversion;
using SolidLibrary.Models;
using SolidLibrary.Services;

Console.WriteLine("Yeap");

Game game = (Game)Factory.CreateGame();
game.Id = 0;
game.Title = "Starfield";
game.Subtitle = "";
game.Price = 0;

Retailer retailer = (Retailer)Factory.CreateRetailer();
retailer.Store = "Steam";
retailer.Game = game;
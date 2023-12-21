using SolidLibrary.Interfaces;
using SolidLibrary.Services;

// Start the application with welcome message
StandardMessager.WishlistRecorderStartMessage();

StandardMessager.SeparatorMessage();

// Create a copy of System Shock
IProduct systemShock = Factory.CreateGame();
systemShock.Id = "0003";
systemShock.Title = "System Shock";
systemShock.Price = 50.00f;

// Create a copy of Van Helsing
IProduct vanHelsing = Factory.CreateGame();
vanHelsing.Id = "0004";
vanHelsing.Title = "The Incredible Adventure of Van Helsing";
vanHelsing.Price = 17.80f;

// Create a copy of Halo
IProduct halo = Factory.CreateGame();
halo.Id = "0117";
halo.Title = "Halo: Combat Evolved";
halo.Price = 30.00f;

// Create a copy of Age of Empire
IProduct ageOfEmpire = Factory.CreateGame();
ageOfEmpire.Id = "0005";
ageOfEmpire.Title = "Age of Empire";
ageOfEmpire.Price = 40.00f;

// Create a list of games to be wishlisted
List<IWishlisted> wishlist = new()
{
    WishlistRecorder.CreateWishlistedIS(systemShock),
    WishlistRecorder.CreateWishlistedRPG(vanHelsing),
    WishlistRecorder.CreateWishlistedFPS(halo),
    WishlistRecorder.CreateWishlistedRTS(ageOfEmpire)
};



// Record each of the game into wishlist 
foreach (var listedGame in wishlist)
{
    WishlistRecorder.Record(listedGame);
}

StandardMessager.SeparatorMessage();
// End the application with goodbye message
StandardMessager.WishlistRecorderEndMessage();
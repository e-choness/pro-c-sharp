// See https://aka.ms/new-console-template for more information

using SolidLibrary.Models;
using SolidLibrary.Services;

StandardMessager.GameStoreStartMessage();

// Not much to look at the code, the examples are from Solid Library
GotyFullGame fullGame = new();
fullGame.GetDescription();

StandardMessager.GameStoreEndMessage();
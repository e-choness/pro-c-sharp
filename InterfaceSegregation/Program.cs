// See https://aka.ms/new-console-template for more information

using SolidLibrary.Models;
using SolidLibrary.Services;

StandardMessager.GameStoreStartMessage();

GotyFullGame fullGame = new();
fullGame.GetDescription();

StandardMessager.GameStoreEndMessage();
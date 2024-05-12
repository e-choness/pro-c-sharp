namespace ProSharp.Interfaces;

public abstract class Vehicle(string make, string model, string color)
{
    public string Make { get; init; } = make;
    public string Model { get; init; } = model;
    public string Color { get; init; } = color;

    public abstract string GetInfo();
}
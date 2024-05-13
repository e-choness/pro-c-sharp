namespace ProSharp.Interfaces;

public abstract class Vehicle(int id, string make, string model, string color)
{
    public int Id { get; set; } = id;
    public string Make { get; init; } = make;
    public string Model { get; init; } = model;
    public string Color { get; init; } = color;

    public abstract string GetInfo();
}
namespace ProSharp.Interfaces;

public class MiniVan(string make, string model, string color) : Vehicle(make, model, color), ICloneable
{
    public object Clone()
    {
        return this;
    }

    public override string GetInfo() => $"This {GetType().Name} Made by {Make} Model: {Model} Color: {Color}";
}
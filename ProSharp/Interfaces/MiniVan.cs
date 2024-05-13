namespace ProSharp.Interfaces;

public class MiniVan(int id, string make, string model, string color) : Vehicle(id, make, model, color), ICloneable, IComparable
{
    public object Clone()
    {
        return this;
    }

    public override string GetInfo() => $"This {GetType().Name} Made by {Make} Model: {Model} Color: {Color}";
    public int CompareTo(object? obj)
    {
        if (obj is not Vehicle temp) throw new ArgumentException("It's not a vehicle. How am I suppose to compare");

        return Id > temp.Id ? 1 : Id < temp.Id ? -1 : 0;
    }
}
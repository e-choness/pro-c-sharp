namespace ProSharp.Serializations;

public class Car
{
    public Radio TheRadio { get; set; } = new();
    public bool IsHatchBack { get; set; }

    public override string ToString() => $"Is Hatch Back: {IsHatchBack} Radio: {TheRadio}";
}

public class JamesBondCar : Car
{
    public bool CanFly { get; set; }
    public bool CamSubmerge { get; set; }
    public override string ToString() => $"Can Fly: {CanFly}, Can Submerge {CamSubmerge} {base.ToString()}";
}
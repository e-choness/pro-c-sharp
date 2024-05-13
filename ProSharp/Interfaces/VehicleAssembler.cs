namespace ProSharp.Interfaces;

public class VehicleAssembler
{
    public static void Assemble()
    {
        Console.WriteLine("=> Assembling a mini van");
        var miniVan = new MiniVan(1, "Toyota", "Sienna", "Blue");
        Console.WriteLine(miniVan.GetInfo());
        CloneMe(miniVan);
    }

    private static void CloneMe(ICloneable clone)
    {
        var theClone = clone.Clone();
        Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
    }

    private static void Compare(MiniVan first, MiniVan second)
    {
        Console.WriteLine($"{first.CompareTo(second)}");
    }

    public static void SeeComparison()
    {
        var first = new MiniVan(3, "LL", "XL", "Black");
        var second = new MiniVan(10, "YEAGER", "SX", "Cyan");
        Compare(first, second);
    }
}
namespace ProSharp.Interfaces;

public class VehicleAssembler
{
    public static void Assemble()
    {
        Console.WriteLine("=> Assembling a mini van");
        var miniVan = new MiniVan("Toyota", "Sienna", "Blue");
        Console.WriteLine(miniVan.GetInfo());
        CloneMe(miniVan);
    }

    private static void CloneMe(ICloneable clone)
    {
        var theClone = clone.Clone();
        Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
    }
}
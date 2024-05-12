namespace ProSharp.PartialClasses;

public class ItemDistributor
{
    public static void Distribute()
    {
        Console.WriteLine("=> Distribute an item with partial class");
        var item = new Item();
        Console.WriteLine(item.GetInfo());
        Console.WriteLine(item.GetInfoWithDescription());
    }
}
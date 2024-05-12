namespace ProSharp.PartialClasses;

public partial class Item
{
    public string? Description { get; set; }= "No description.";
    
    public string GetInfoWithDescription()
    {
        return $"The item info with description - Name: {Name} Description: {Description}";
    }
}
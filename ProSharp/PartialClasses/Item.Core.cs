namespace ProSharp.PartialClasses;

public partial class Item(int id, string name, DateTime creationDate)
{
    public int Id { get; init; } = id;
    public string Name { get; set; } = name;
    public DateTime CreationDate { get; init; } = creationDate;

    public Item() : this(0, "Default", DateTime.Now) { }

    public string GetInfo()
    {
        return $"The item info - ID: {Id} Name - {Name} Creation Date: {CreationDate}";
    }
}
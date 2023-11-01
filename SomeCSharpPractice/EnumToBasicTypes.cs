namespace SomeCSharpPractice;

public enum ContentType
{
    Game,
    Shard,
	ShipUpgrade,
    Vessel,
    Crystal
}
public class EnumToBasicTypes
{
    public static string ConvertEnumToString(ContentType contentType)
    {
        return contentType.ToString();
    }

    public static int ConvertEnumToInt(ContentType contentType)
    {
        return (int)contentType;
    }
}
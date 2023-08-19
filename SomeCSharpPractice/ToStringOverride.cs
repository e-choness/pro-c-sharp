namespace SomeCSharpPractice;

public class ToStringOverride
{
    public static void DisplayResult()
    {
        Vehicle vehicle = new("Monstag", "Large", 2020, 06);
        Console.WriteLine(vehicle.ToString());
        // ToString() will be implicitly called when it's not called in Console.WriteLine()
        Console.WriteLine(vehicle);
    }
}

class Vehicle
{
    private String _name;
    private String _type;
    private int _year;
    private int _month;

    public Vehicle(string name, string type, int year, int month)
    {
        _name = name;
        _type = type;
        _year = year;
        _month = month;
    }
    public override string ToString()
    {
        return $"{_name} {_type} {_year} {_month}";
    }
}
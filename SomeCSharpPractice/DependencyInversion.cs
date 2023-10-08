using System.Diagnostics;

namespace SomeCSharpPractice;

public class DependencyInversion
{
    public void DisplayResult()
    {
        
       
    }
}

public abstract class Beverage
{
    protected string? Description;
    protected double Price;

    protected Beverage(string? description, double price)
    {
        Description = description;
        Price = price;
    }

    public abstract string? Cost();

    public virtual string? GetDescription()
    {
        return Description;
    }
}

public class HouseBlend : Beverage
{
    
    public HouseBlend(string? description, double price) : base(description, price)
    {
        Description = description;
        Price = price;
    }

    public override string? Cost()
    {
        return Description;
    }
}

public class DarkRoast : Beverage
{
    public DarkRoast(string? description, double price) : base(description, price)
    {
        Description = description;
        Price = price;
    }

    public override string? Cost()
    {
        return Description;
    }
}

public interface IAddOn
{
    
}
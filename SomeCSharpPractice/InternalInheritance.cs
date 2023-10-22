using System;
namespace SomeCSharpPractice;

public class InternalInheritance
{
    private TheThing _theThing = new TheThing(123456);
    private TheThingChild _theThingChild = new TheThingChild(12345678);

    private TheThing _anotherThing = new TheThing(1, 123);
    private TheThingChild _anotherChild = new TheThingChild(2, 1234);

    public void DisplayResult()
    {
        Console.WriteLine($"The thing id {_theThing.Id} super secret id {_theThing.SuperSecretId}");
        Console.WriteLine($"The thing id {_theThingChild.Id} super secret id {_theThingChild.SuperSecretId}");
        
        Console.WriteLine($"Another thing id: {_anotherThing.Id} super secret id: {_anotherThing.SuperSecretId}");
        Console.WriteLine($"Another child id: {_anotherChild.Id} super secret id: {_anotherChild.SuperSecretId}");
    }
}

public class TheThing
{
    public int Id;
    // switching from internal to private or protected will yield compiler error
    // protected internal will be fine
    protected internal int SuperSecretId; 

    internal TheThing(int id, int superSecretId)
    {
        Id = id;
        SuperSecretId = superSecretId;
    }
    internal TheThing(int superSecretId)
    {
        SuperSecretId = superSecretId;
    }
}

public class TheThingChild : TheThing
{
    internal TheThingChild(int id, int superSecretId) : base(id, superSecretId)
    {
        
    }
    internal TheThingChild(int superSecretId) : base(superSecretId)
    {
    }
}
namespace ProSharp.Serializations;

public class Person
{
    public bool IsAlive { get; set; } = true;
    public int Age { get; set; } = 21;
    public string FirstName { get; set; } = string.Empty;
    public override string ToString() => $"Is Alive: {IsAlive} First Name: {FirstName} Age: {Age}";
}
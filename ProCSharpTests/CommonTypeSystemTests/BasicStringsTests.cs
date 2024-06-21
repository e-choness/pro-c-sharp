using ProSharp.CommonTypeSystem;

namespace ProCSharpTests.CommonTypeSystemTests;

public class BasicStringsTests
{
    private const string FirstName = "Freddy";

    [Test]
    public void GetValueTextPass()
    {
        var actual = $"The value of input: {FirstName}";
        var result = BasicStrings.GetValueText(FirstName);
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void GetLengthTextPass()
    {
        var actual = $"The input {FirstName} has {FirstName.Length} characters.";
        var result = BasicStrings.GetLengthText(FirstName);
        Assert.That(actual, Is.EqualTo(result));
    }

    [Test]
    public void GetUpperTextPass()
    {
        var actual = $"The input {FirstName} in uppercase {FirstName.ToUpper()}";
        var result = BasicStrings.GetUpperText(FirstName);
        Assert.That(actual, Is.EqualTo(result));
    }

    [Test]
    public void GetLowerTextPass()
    {
        var actual = $"The input {FirstName} in lowercase {FirstName.ToLower()}";
        var result = BasicStrings.GetLowerText(FirstName);
        Assert.That(actual, Is.EqualTo(result));
    }

    [Test]
    public void GetIsSubstringTextPass()
    {
        var sub = "dy";
        var actual = $"The input {FirstName} contains {sub}";
        var result = BasicStrings.GetIsSubstringText(FirstName, sub);
        Assert.That(actual, Is.EqualTo(result));
    }

    [Test]
    public void GetRepalceTextPass()
    {
        var newValue = "ric";
        var oldValue = "dy";
        var newFirstName = FirstName.Replace(oldValue, newValue);
        var actual = $"The input {FirstName}'s {oldValue} is replaced by {newValue}, the result is {newFirstName}";
        var result = BasicStrings.GetReplaceText(FirstName, newValue, oldValue);
        Assert.That(actual, Is.EqualTo(result));
    }
}
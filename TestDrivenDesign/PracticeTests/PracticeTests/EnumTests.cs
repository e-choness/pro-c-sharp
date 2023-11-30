using NuGet.Frameworks;

namespace PracticeTests;

[TestFixture]
public class EnumTests
{
    private enum ContentType
    {
        MiniGame,
        ShipClass,
        Crystal,
        Vessel,
        VesselUpgrade,
        VesselKnowledge
    }
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void EnumToStringTest()
    {
        var result = nameof(ContentType.MiniGame);
        Assert.That(result, Is.EqualTo("MiniGame"));
    }
}
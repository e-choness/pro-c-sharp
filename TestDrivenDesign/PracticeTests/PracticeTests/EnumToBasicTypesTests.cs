using SomeCSharpPractice;

namespace PracticeTests;

public class EnumToBasicTypesTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestReturnShip()
    {
        Assert.That(EnumToBasicTypes.ConvertEnumToString(ContentType.ShipUpgrade), Is.EqualTo(nameof(ContentType.ShipUpgrade)));
    }

    [Test]
    public void TestReturn0_ConvertGameToInt()
    {
        const int expected = 0;
        Assert.AreEqual(expected, EnumToBasicTypes.ConvertEnumToInt(ContentType.Game));
    }
}
using ProSharp.Parameters;

namespace ProCSharpTests.Parameters;

public class AverageCalculatorTests
{
    [Test]
    public void CalculateAverage_ShouldReturnZero_WhenNoValuesProvided()
    {
        var result = MethodParams.CalculateAverage();
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void CalculateAverage_ShouldReturnValue_WhenSingleValueProvided()
    {
        var result = MethodParams.CalculateAverage(5.0);
        Assert.That(result, Is.EqualTo(5.0));
    }

    [Test]
    public void CalculateAverage_ShouldReturnCorrectAverage_WhenMultipleValuesProvided()
    {
        var result = MethodParams.CalculateAverage(2.0, 4.0, 6.0);
        Assert.That(result, Is.EqualTo(4.0));
    }

    [Test]
    public void CalculateAverage_ShouldHandleNegativeValues()
    {
        var result = MethodParams.CalculateAverage(-2.0, -4.0, -6.0);
        Assert.That(result, Is.EqualTo(-4.0));
    }

    [Test]
    public void CalculateAverage_ShouldHandleMixedValues()
    {
        var result = MethodParams.CalculateAverage(-2.0, 0.0, 2.0);
        Assert.That(result, Is.EqualTo(0.0));
    }
}
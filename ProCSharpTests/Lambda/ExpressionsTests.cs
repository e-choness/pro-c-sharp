using ProSharp.Lambda;

namespace ProCSharpTests.Lambda;


public class ExpressionsTests
{
    [TestCase(2,3,5)]
    [TestCase(0,0,0)]
    [TestCase(-2, -3, -5)]
    public void AddTwoNumbers_ShouldPass(int x, int y, int expected)
    {
        Assert.That(Expressions.Add(x, y), Is.EqualTo(expected));
    }

    [TestCase(2,3,6)]
    [TestCase(0,0,1)]
    [TestCase(-2,-3,0)]
    public void AddTowNumbers_ShouldFail(int x, int y, int expected)
    {
        Assert.That(expected, Is.Not.EqualTo(Expressions.Add(x, y)));
    }

    [TestCase(2,3,5)]
    [TestCase(0,0,0)]
    [TestCase(-2, -3, -5)]
    public void AddWrapperTwoNumbers_ShouldPass(int x, int y, int expected)
    {
        Assert.That(Expressions.AddWrapper(x,y), Is.EqualTo(expected));
    }

    [TestCase(2,3,6)]
    [TestCase(0,0,1)]
    [TestCase(-2,-3,0)]
    public void AddWrapperTwoNumbers_ShouldFail(int x, int y, int expected)
    {
        Assert.That(Expressions.AddWrapper(x,y), Is.Not.EqualTo(expected));
    }
}
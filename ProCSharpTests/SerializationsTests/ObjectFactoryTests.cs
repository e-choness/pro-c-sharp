using ProSharp.Serializations;

namespace ProCSharpTests.SerializationsTests;

public class ObjectFactoryTests
{
    [Test]
    public void FirstJamesBondCarCanFlyPass()
    {
        const bool firstCarCanFlyExpect = true;
        
        var cars = ObjectFactory.GetJamesBondCars();
        var firstCarCanFlyResult = cars.First().CanFly;
        
        
        Assert.That(firstCarCanFlyResult, Is.EqualTo(firstCarCanFlyExpect));
    }

    [Test]
    public void FirstJamesBondCarCanSubmergePass()
    {
        const bool firstCarCanSubmergeExpect = true;
        
        var cars = ObjectFactory.GetJamesBondCars();
        var firstCarCanSubmergeResult = cars.First().CamSubmerge;
        
        Assert.That(firstCarCanSubmergeResult, Is.EqualTo(firstCarCanSubmergeExpect));
    }

    [Test]
    public void GetPersonFirstNamePass()
    {
        const string firstNameExpect = "James";
        
        var personResult = ObjectFactory.GetPerson(firstNameExpect, true);
        
        Assert.That(personResult.FirstName, Is.EqualTo(firstNameExpect));
    }

    [Test]
    public void GetPersonIsAlivePass()
    {
        const bool isAliveExpect = true;

        var personResult = ObjectFactory.GetPerson("James", true);
        
        Assert.That(personResult.IsAlive, Is.EqualTo(isAliveExpect));
    }
}
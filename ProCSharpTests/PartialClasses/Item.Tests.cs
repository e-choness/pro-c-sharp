using ProSharp.PartialClasses;

namespace ProCSharpTests.PartialClasses;

public class ItemTests
{
    [Test]
    public void Item_ShouldInitializeCorrectly_WhenGivenValidInputs()
    {
        const int id = 1;
        const string name = "Test Item";
        var creationDate = new DateTime(2023, 1, 1);
        
        var item = new Item(id, name, creationDate);

        Assert.Multiple(() =>
        {
            Assert.That(item.Id, Is.EqualTo(id));
            Assert.That(item.Name, Is.EqualTo(name));
            Assert.That(item.CreationDate, Is.EqualTo(creationDate));
            Assert.That(item.Description, Is.EqualTo("No description."));
        });
    }

    [Test]
    public void Item_DefaultConstructor_ShouldInitializeWithDefaultValues()
    {
        var item = new Item();

        Assert.Multiple(() =>
        {
            Assert.That(item.Id, Is.EqualTo(0));
            Assert.That(item.Name, Is.EqualTo("Default"));
            Assert.That(item.CreationDate.Date, Is.EqualTo(DateTime.Now.Date));
            Assert.That(item.Description, Is.EqualTo("No description."));
        });
    }

    [Test]
    public void GetInfo_ShouldReturnCorrectInfo()
    {
        const int id = 1;
        const string name = "Test Item";
        var creationDate = new DateTime(2023, 1, 1);
        
        var item = new Item(id, name, creationDate);

        var expectedInfo = $"The item info - ID: {id} Name - {name} Creation Date: {creationDate}";
        Assert.That(item.GetInfo(), Is.EqualTo(expectedInfo));
    }

    [Test]
    public void GetInfoWithDescription_ShouldReturnCorrectInfoWithDescription()
    {
        const int id = 1;
        const string name = "Test Item";
        var creationDate = new DateTime(2023, 1, 1);
        const string description = "This is a test item.";
        
        var item = new Item(id, name, creationDate)
        {
            Description = description
        };

        const string expectedInfo = $"The item info with description - Name: {name} Description: {description}";
        Assert.That(item.GetInfoWithDescription(), Is.EqualTo(expectedInfo));
    }
}